﻿namespace Entities.RequestParameters
{
    public class FoodParameters : RequestParameters
    {
        public uint MinPrice { get; set; }
        public uint MaxPrice { get; set; } = 1000;
        public bool ValidPriceRange => MaxPrice > MinPrice;

        public string? Search { get; set; }
    }
}
