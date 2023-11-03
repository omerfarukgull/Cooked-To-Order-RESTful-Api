using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Services.Abstract;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Services.Concrete
{
    public class AuthenticationManager : IAuthenticationService
    {
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        private User? _user;

        public AuthenticationManager(ILoggerService logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<User>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);

            return result;
        }

        public async Task<bool> ValidateUser(UserForAuthenticationDto userforAutDto)
        {
            _user = await _userManager.FindByNameAsync(userforAutDto.UserName);

            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, userforAutDto.Password));

            if (!result)
            {
                _logger.LogWarnnig($"{nameof(ValidateUser)} : Authentication failed. Wrong username or password");
            }
            return result;
        }
        public async Task<TokenDto> CreateToken(bool populateExp)
        {
            var singinCredentials = GetSinginCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(singinCredentials, claims);

            var refreshToken = GenerateRefreshToken();
            _user.RefreshToken= refreshToken;
            if (populateExp)
                _user.RefreshTokenExpriyTime=DateTime.Now.AddDays(1);

            await _userManager.UpdateAsync(_user);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return new TokenDto 
            { 
                AccessToken = accessToken,
                RefreshToken= refreshToken,
            };
        }

        private SigningCredentials GetSinginCredentials()
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var key = Encoding.UTF8.GetBytes(jwtSettings["secretKey"]);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,_user.UserName)
            };
            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials singinCredentials, List<Claim> claims)
        {
            var jwtSetting = _configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken(
                    issuer: jwtSetting["validIssuer"],
                    audience: jwtSetting["validAudience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSetting["expires"])),
                    signingCredentials: singinCredentials
                );
            return tokenOptions;
        }
        private string GenerateRefreshToken()
        {
            var randomNumber=new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }

        }
        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["secretKey"];

            var tokenValidationParameters = new TokenValidationParameters//JWT kimlik doğrulama düzeninin yapılandırma ayarlarını içeren bir nesnedir. JWT tokenlarının doğrulama parametrelerini belirlemek için kullanılır.
            {
                //JWT'nin Validate + "issuer,Audience,LifetimeIssuerSigningKey" alanların doğrulanıp doğrulanmayacağını belirtir. 
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                // JWT'nin doğrulanırken, bu yayımcı adı ile eşleşmelidir.
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;

            //Doğrulama işleminden kullanıcı bilgilerini alıyoruz
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);

            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken is null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid Token");
            }


            return principal;
        }

        public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
        {
            var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
            var user = await _userManager.FindByNameAsync(principal.Identity.Name);

            if (user is null || user.RefreshToken != tokenDto.RefreshToken || user.RefreshTokenExpriyTime <= DateTime.Now)
                throw new RefreshTokenBadRequestException();

            _user = user;

            return await CreateToken(false);
        }
    }
}
