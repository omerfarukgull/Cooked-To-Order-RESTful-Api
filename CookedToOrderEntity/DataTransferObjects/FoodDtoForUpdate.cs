using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderEntity.DataTransferObjects
{
    public record FoodDtoForUpdate : FoodDtoForManipulation
    {
        [Required]
        public int FoodId { get; set;}
    }
}
