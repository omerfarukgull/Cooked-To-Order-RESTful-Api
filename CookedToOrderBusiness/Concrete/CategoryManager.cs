using CookedToOrderBusiness.Abstract;
using CookedToOrderData.Abstract;
using CookedToOrderEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderBusiness.Concrete
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
