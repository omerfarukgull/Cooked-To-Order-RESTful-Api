using CookedToOrderEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderBusiness.Abstract
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
