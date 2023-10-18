
using CookedToFoodCore.DataAccess;
using CookedToOrderEntity.Models;
using Entities.RequestParameters;


namespace CookedToOrderData.Abstract
{
    public interface IFoodRepository:IRepository<Food>
    {
        Task<PagedList<Food>> GetAllFoodsAsync(FoodParameters foodParameters);
    }
}
