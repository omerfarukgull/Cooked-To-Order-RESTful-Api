using CookedToOrderData.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderData.Concrete
{
    public class RepositoryManager:IRepositoryManager
    {
        private readonly FoodContext _context;
        private readonly Lazy<IFoodRepository> _foodRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        public RepositoryManager(FoodContext context)
        {
            _context = context;
            _foodRepository = new Lazy<IFoodRepository>(() => new EfFoodRepository(_context));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new EfCategoryRepository(_context));
        }

        public IFoodRepository Food => _foodRepository.Value;

        public ICategoryRepository Category => _categoryRepository.Value;

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
