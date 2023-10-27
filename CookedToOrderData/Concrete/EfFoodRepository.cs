using Core.DataAccess.Ef;
using Entities.Models;
using Entities.RequestParameters;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;


namespace Repositories.Concrete
{
    public sealed class EfFoodRepository : EfCoreGenericRepository<Food>, IFoodRepository
    {
        public EfFoodRepository(FoodContext context) : base(context)
        {

        }

        public async Task<PagedList<Food>> GetAllFoodsAsync(FoodParameters foodParameters)
        {
            var foods = await GetList()
                        .FilterFoods(foodParameters.MinPrice, foodParameters.MaxPrice)
                        .SearchFood(foodParameters.Search)
                        .OrderBy(f => f.FoodId)
                        .ToListAsync();
            return PagedList<Food>.ToPagedList(foods, foodParameters.PageNumber, foodParameters.PageSize);
        }

    }
}
