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
        Task<List<Category>> GetFoodListAsync();
        Task<Category> GetOneFoodByIdAsync();
        Task<Category> CreateOneBookAsync(Category category);
        Task UpdateOneBookAsync(int id, Category category);
        Task DeleteOneBookAsync(int id);
    }
}
