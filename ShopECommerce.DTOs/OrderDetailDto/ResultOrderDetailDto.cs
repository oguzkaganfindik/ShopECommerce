using System.ComponentModel.DataAnnotations.Schema;

namespace ShopECommerce.DTOs.OrderDetailDto
{
    public class ResultOrderDetailDto
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
