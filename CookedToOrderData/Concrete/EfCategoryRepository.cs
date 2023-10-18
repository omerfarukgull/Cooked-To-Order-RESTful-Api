using CookedToFoodCore.DataAccess.Ef;
using CookedToOrderData.Abstract;
using CookedToOrderEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderData.Concrete
{
    public class EfCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
      
        public EfCategoryRepository(FoodContext context) : base(context)
        {

        }
    }
}
