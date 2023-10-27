using Entities.Models;
using Repositories.Abstract;
using Services.Abstract;


namespace Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;
        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public Task<Category> CreateOneBookAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOneBookAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetFoodListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetOneFoodByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateOneBookAsync(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
