using Entities.Models;
using Entities.RequestParameters;


namespace Repositories.Abstract
{
    public interface IFoodRepository:IRepositortBase<Food>
    {
        Task<PagedList<Food>> GetAllFoodsAsync(FoodParameters foodParameters);
        Task<IEnumerable<Food>> GetAllFoodWithDetailsAsync();
    }
}
