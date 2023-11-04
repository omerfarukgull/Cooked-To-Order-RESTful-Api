using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;

namespace Repositories.Concrete
{
    public class EfCategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
      
        public EfCategoryRepository(FoodContext context) : base(context)
        {

        }
    }
}
