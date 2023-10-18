using CookedToOrderEntity.DataTransferObjects;
using CookedToOrderEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderBusiness.Abstract
{
    public interface IFoodService
    {
        Task<List<Food>> GetFoodListAsync();
        Task<FoodDto> GetOneFoodByIdAsync(int id);
        Task<FoodDto> CreateOneBookAsync(FoodDtoForInsertion foodDto);
        Task UpdateOneBookAsync(int id, FoodDtoForUpdate foodDto);
        Task DeleteOneBookAsync(int id);
    }
}
