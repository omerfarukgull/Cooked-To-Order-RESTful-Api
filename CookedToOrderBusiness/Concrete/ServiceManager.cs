using AutoMapper;
using Entities.DataTransferObjects;
using Repositories.Abstract;
using Services.Abstract;

namespace Services.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IFoodService> _foodService;
        private readonly Lazy<ICategoryService> _categoryServicey;
        public ServiceManager(IRepositoryManager repositoryManager,IMapper mapper,ILoggerService logger,IDataShaper<FoodDto> shaper)
        {
            _foodService = new Lazy<IFoodService>(()=> new FoodManager(repositoryManager, mapper,logger,shaper));
            _categoryServicey = new Lazy<ICategoryService>(()=> new CategoryManager(repositoryManager));
        }
        public IFoodService FoodService => _foodService.Value;

        public ICategoryService CategoryService => _categoryServicey.Value;
    }
}
