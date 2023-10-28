
using Entities.DataTransferObjects;
using Entities.RequestParameters;
using System.Dynamic;

namespace Services.Abstract
{
    public interface IFoodService
    {
        Task<(IEnumerable<ExpandoObject> foods,MetaData metaData)> GetAllFoodsAsync(FoodParameters foodParameters);
        Task<FoodDto> GetOneFoodByIdAsync(int id);
        Task<FoodDto> CreateOneBookAsync(FoodDtoForInsertion foodDto);
        Task UpdateOneBookAsync(int id, FoodDtoForUpdate foodDto);
        Task DeleteOneBookAsync(int id);
    }
}
