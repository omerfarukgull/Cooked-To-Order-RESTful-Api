using CookedToOrderEntity.DataTransferObjects;
using CookedToOrderEntity.Models;
using Entities.RequestParameters;

namespace CookedToOrderBusiness.Abstract
{
    public interface IFoodService
    {
        Task<IEnumerable<FoodDto>> GetAllFoodsAsync(FoodParameters foodParameters);
        Task<FoodDto> GetOneFoodByIdAsync(int id);
        Task<FoodDto> CreateOneBookAsync(FoodDtoForInsertion foodDto);
        Task UpdateOneBookAsync(int id, FoodDtoForUpdate foodDto);
        Task DeleteOneBookAsync(int id);
    }
}
