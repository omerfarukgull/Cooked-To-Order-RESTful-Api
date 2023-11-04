
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestParameters;
using System.Dynamic;

namespace Services.Abstract
{
    public interface IFoodService
    {
        Task<(IEnumerable<ExpandoObject> foods,MetaData metaData)> GetAllFoodsAsync(FoodParameters foodParameters);
        Task<FoodDto> GetOneFoodByIdAsync(int id);
        Task<FoodDto> CreateOneFoodAsync(FoodDtoForInsertion foodDto);
        Task UpdateOneFoodAsync(int id, FoodDtoForUpdate foodDto);
        Task DeleteOneFoodAsync(int id);
        Task<IEnumerable<Food>> GetAllFoodWithDetailsAsync();
    }
}
