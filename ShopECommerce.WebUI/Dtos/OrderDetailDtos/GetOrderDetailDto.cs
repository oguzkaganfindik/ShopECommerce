﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ShopECommerce.WebUI.Dtos.OrderDetailDtos
{
    public class GetOrderDetailDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }
        public bool Status { get; set; }
    }
}
