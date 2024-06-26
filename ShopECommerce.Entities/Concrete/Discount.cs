﻿using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Discount : BaseEntity
    {
        public string Title { get; set; }
        public string? Amount { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
