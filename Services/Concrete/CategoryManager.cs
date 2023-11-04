using Entities.Exceptions;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Category> CreateOneCategoryAsync(Category category)
        {
            _manager.Category.Create(category);
            await _manager.SaveAsync();
            return category;
        }

        public async Task DeleteOneCategoryAsync(int id)
        {
            var entity = await GetOneCategoryByIdAndCheckExists(id);
            _manager.Category.Delete(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _manager.Category.GetList()
                  .OrderBy(c => c.CategoryName).ToListAsync();
        }

        public async Task<Category> GetOneCategoryByIdAsync(int id)
        {
            var category = await GetOneCategoryByIdAndCheckExists(id);
            return category;
        }

        public async Task UpdateOneCategoryAsync(int id, Category category)
        {
            var entity = await GetOneCategoryByIdAndCheckExists(id);
            _manager.Category.Update(category);
            await _manager.SaveAsync();
        }
        private async Task<Category> GetOneCategoryByIdAndCheckExists(int id)
        {
            var entity = _manager.Category.Get(c => c.CategoryId == id);
            if (entity is null)
                throw new CategoryNotFoundException(id);

            return entity;
        }
    }
}
