﻿namespace ShopECommerce.WebUI.Dtos.DiscountDtos
{
    public class CreateDiscountDto
    {
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool Status { get; set; }

    }
}
