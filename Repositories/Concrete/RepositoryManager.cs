
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public class RepositoryManager:IRepositoryManager
    {
        private readonly FoodContext _context;
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RepositoryManager(FoodContext context, IFoodRepository foodRepository, ICategoryRepository categoryRepository)
        {
            _context = context;
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
        }

        public IFoodRepository Food => _foodRepository;

        public ICategoryRepository Category => _categoryRepository;

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
