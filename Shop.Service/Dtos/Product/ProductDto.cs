﻿namespace Shop.Service.Dtos.Product
{
    public class ProductDto : BaseDto<int>
    {
        public string  Name { get; set; }

        public int CategoryId { get; set; }

    }
}