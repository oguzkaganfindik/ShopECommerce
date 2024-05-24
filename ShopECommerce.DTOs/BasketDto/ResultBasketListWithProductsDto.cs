namespace ShopECommerce.DTOs.BasketDto
{
    public class ResultBasketListWithProductsDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public int BasketItemId { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
    }
}
