using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderData.Abstract
{
    public interface IRepositoryManager
    {
        IFoodRepository Food { get; }
        ICategoryRepository Category { get; }

        Task SaveAsync();
    }
}
