using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repositories.Abstract;
using Services.Abstract;

namespace Services.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IFoodService> _foodService;
        private readonly Lazy<ICategoryService> _categoryServicey;
        private readonly Lazy<IAuthenticationService> _authenticationService;
        public ServiceManager(IRepositoryManager repositoryManager,IMapper mapper,
                                ILoggerService logger,
                                IDataShaper<FoodDto> shaper,
                                UserManager<User> userManager,
                                IConfiguration configuration)
        {
            _foodService = new Lazy<IFoodService>(()=> new FoodManager(repositoryManager, mapper,logger,shaper));
            _categoryServicey = new Lazy<ICategoryService>(()=> new CategoryManager(repositoryManager));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationManager(logger,mapper,userManager,configuration));
        }
        public IFoodService FoodService => _foodService.Value;

        public ICategoryService CategoryService => _categoryServicey.Value;

        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
