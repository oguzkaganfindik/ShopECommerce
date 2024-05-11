﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ShopECommerce.DTOs.OrderDto
{
    public class GetOrderDto
    {
        public int Id { get; set; }
        public string TableNumber { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
    }
}
