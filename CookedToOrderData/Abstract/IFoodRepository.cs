using Core.DataAccess;
using Entities.Models;
using Entities.RequestParameters;


namespace Repositories.Abstract
{
    public interface IFoodRepository:IRepository<Food>
    {
        Task<PagedList<Food>> GetAllFoodsAsync(FoodParameters foodParameters);
    }
}
