using CookedToFoodCore.DataAccess.Ef;
using CookedToOrderData.Abstract;
using CookedToOrderEntity.Models;
using Entities.RequestParameters;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CookedToOrderData.Concrete
{
    public class EfFoodRepository : EfCoreGenericRepository<Food>, IFoodRepository
    {
        public EfFoodRepository(FoodContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Food>> GetAllFoodsAsync(FoodParameters foodParameters) =>
            await GetList()
            .OrderBy(f=>f.FoodId)
            .Skip((foodParameters.PageNumber-1)*foodParameters.PageSize)
            .Take(foodParameters.PageSize)
            .ToListAsync();
    }
}
