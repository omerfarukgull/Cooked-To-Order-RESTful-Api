using CookedToFoodCore.DataAccess.Ef;
using CookedToOrderData.Abstract;
using CookedToOrderEntity.Models;

namespace CookedToOrderData.Concrete
{
    public class EfFoodRepository:EfCoreGenericRepository<Food>,IFoodRepository
    {
        public EfFoodRepository(FoodContext context):base(context)
        {

        }
    }
}
