using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class FoodNotFoundException : NotFoundException
    {
        public FoodNotFoundException(int id) : base($"Bu {id} İd'li Yemek bulunamadı. ")
        {
        }
    }
}
