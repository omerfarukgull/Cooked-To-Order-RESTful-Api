using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    [Serializable]
    public record FoodDto()
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public decimal FoodPrice { get; set; }
        public string ImgUrl { get; set; }

        public int CategoryId { get; set; }
    }
}
