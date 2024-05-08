namespace ShopECommerce.DTOs.BasketDto
{
    public class CreateBasketDto
    {
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public int ShopTableId { get; set; }
    }
}
