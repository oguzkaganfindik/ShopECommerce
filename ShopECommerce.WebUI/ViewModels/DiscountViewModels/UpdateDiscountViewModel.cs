﻿namespace ShopECommerce.WebUI.ViewModels.DiscountViewModels
{
    public class UpdateDiscountViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Amount { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool Status { get; set; }
        public IFormFile? File { get; set; }
    }
}
