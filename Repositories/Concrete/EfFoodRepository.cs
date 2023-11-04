
using Entities.Models;
using Entities.RequestParameters;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Concrete.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public sealed class EfFoodRepository : RepositoryBase<Food>, IFoodRepository
    {
        public EfFoodRepository(FoodContext context) : base(context)
        {

        }

        public async Task<PagedList<Food>> GetAllFoodsAsync(FoodParameters foodParameters)
        {
            var foods = await GetList()
                        .FilterFoods(foodParameters.MinPrice, foodParameters.MaxPrice)
                        .SearchFood(foodParameters.Search)
                        .Include(f=>f.Category)
                        .Sort(foodParameters.OrderBy)
                        .ToListAsync();
            return PagedList<Food>.ToPagedList(foods, foodParameters.PageNumber, foodParameters.PageSize);
        }

        public async Task<IEnumerable<Food>> GetAllFoodWithDetailsAsync()
        {
            return await _context.Foods.Include(f=>f.Category).OrderBy(b=>b.FoodId).ToArrayAsync();
        }
    }
}
