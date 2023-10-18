using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderEntity.DataTransferObjects
{
    public abstract record FoodDtoForManipulation
    {
        [Required(ErrorMessage = "FoodName is required field")]
        [MinLength(2, ErrorMessage = "Title must consist of at least 2 characters")]
        [MaxLength(50, ErrorMessage = "Title must consist of at maximum 50 characters")]
        public string FoodName { get; set; }


        [Required(ErrorMessage = "FoodDescription is required field")]
        [MinLength(2, ErrorMessage = "Title must consist of at least 2 characters")]
        [MaxLength(50, ErrorMessage = "Title must consist of at maximum 350 characters")]
        public string FoodDescription { get; set; }


        [Required(ErrorMessage = "FoodPrice is required field")]
        public decimal FoodPrice { get; set; }


        [Required(ErrorMessage = "ImgUrl is required field")]
        public string ImgUrl { get; set; }


        [Required(ErrorMessage = "CategoryId is required field")]
        public int CategoryId { get; set; }
    }
}
