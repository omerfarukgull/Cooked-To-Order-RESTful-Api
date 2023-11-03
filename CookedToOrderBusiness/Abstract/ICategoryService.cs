using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetOneCategoryByIdAsync(int id);
        Task<Category> CreateOneCategoryAsync(Category category);
        Task UpdateOneCategoryAsync(int id, Category category);
        Task DeleteOneCategoryAsync(int id);
    }
}
