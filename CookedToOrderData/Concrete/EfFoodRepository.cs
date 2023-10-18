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

        public async Task<PagedList<Food>> GetAllFoodsAsync(FoodParameters foodParameters)
        {
            var foods = await GetList()
                        .OrderBy(f => f.FoodId)
                        .ToListAsync();
            return PagedList<Food>.ToPagedList(foods, foodParameters.PageNumber, foodParameters.PageSize);
        }

    }
}
