using Entities.Models;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;

namespace Repositories.Concrete.Extensions
{
    public static class FoodRepositoryExtensions
    {
        public static IQueryable<Food> FilterFoods(this IQueryable<Food> foods, uint minPrice, uint maxPrice)
            => foods.Where(food => (food.FoodPrice >= minPrice) && (food.FoodPrice <= maxPrice));
        public static IQueryable<Food> SearchFood(this IQueryable<Food> foods, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) 
                return foods;

            var lowerCasesearchTerm = searchTerm.Trim().ToLower();

            return foods.Where(f => f.FoodName.ToLower().Contains(lowerCasesearchTerm));
        }

        public static IQueryable<Food> Sort(this IQueryable<Food> foods, string orderByQueryString)
        {
            if(string.IsNullOrWhiteSpace(orderByQueryString))
                return foods.OrderBy(b=>b.FoodId);
            
            var orderQuery = OrderQueryBuilder.CreateorderQuery<Food>(orderByQueryString);
          
            if (orderQuery is null)
                return foods.OrderBy(f=>f.FoodId);


            return foods.OrderBy(orderQuery);
        }
    }
}

