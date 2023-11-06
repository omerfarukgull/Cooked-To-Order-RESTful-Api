using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public record FoodDtoForUpdate : FoodDtoForManipulation
    {
        [Required]
        public int FoodId { get; init; }

        [Required(ErrorMessage = "kategori İd zorunlu bir alan")]
        public int CategoryId { get; init; }
    }
}
