using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderBusiness.Abstract
{
    public interface IServiceManager
    {
        IFoodService FoodService { get; }
        ICategoryService CategoryService { get; }
    }
}
