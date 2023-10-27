using Core.DataAccess.Ef;
using Entities.Models;
using Repositories.Abstract;


namespace Repositories.Concrete
{
    public class EfCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
      
        public EfCategoryRepository(FoodContext context) : base(context)
        {

        }
    }
}
