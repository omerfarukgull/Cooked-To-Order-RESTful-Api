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
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthenticationService _authenticationService;

        public ServiceManager(IFoodService foodService, ICategoryService categoryService, IAuthenticationService authenticationService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
            _authenticationService = authenticationService;
        }

        public IFoodService FoodService => _foodService;

        public ICategoryService CategoryService => _categoryService;

        public IAuthenticationService AuthenticationService => _authenticationService;
    }
}
