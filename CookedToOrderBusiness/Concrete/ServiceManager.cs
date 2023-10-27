using AutoMapper;
using Repositories.Abstract;
using Services.Abstract;

namespace Services.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IFoodService> _foodService;
        private readonly Lazy<ICategoryService> _categoryServicey;
        public ServiceManager(IRepositoryManager repositoryManager,IMapper mapper,ILoggerService logger)
        {
            _foodService = new Lazy<IFoodService>(()=> new FoodManager(repositoryManager, mapper,logger));
            _categoryServicey = new Lazy<ICategoryService>(()=> new CategoryManager(repositoryManager));
        }
        public IFoodService FoodService => _foodService.Value;

        public ICategoryService CategoryService => _categoryServicey.Value;
    }
}
