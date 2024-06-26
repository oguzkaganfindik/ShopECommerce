﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ShopECommerce.DTOs.OrderDto
{
    public class ResultOrderDto
    {
        public int Id { get; set; }
        public int BasketItemId { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
    }
}
