using Entities.Models;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public static class FoodRepositoryExtensions
    {
        public static IQueryable<Food> FilterFoods(this IQueryable<Food> foods, uint minPrice, uint maxPrice)
            => foods.Where(food => (food.FoodPrice >= minPrice) && (food.FoodPrice <= maxPrice));
    }
}
