
using Entities.DataTransferObjects;
using Entities.RequestParameters;

namespace Services.Abstract
{
    public interface IFoodService
    {
        Task<(IEnumerable<FoodDto> foodDto,MetaData MetaData)> GetAllFoodsAsync(FoodParameters foodParameters);
        Task<FoodDto> GetOneFoodByIdAsync(int id);
        Task<FoodDto> CreateOneBookAsync(FoodDtoForInsertion foodDto);
        Task UpdateOneBookAsync(int id, FoodDtoForUpdate foodDto);
        Task DeleteOneBookAsync(int id);
    }
}
