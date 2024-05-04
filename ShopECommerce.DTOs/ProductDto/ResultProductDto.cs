namespace ShopECommerce.DTOs.ProductDto
{
    public class ResultProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int SubCategoryId { get; set; }
        public bool Status { get; set; }

    }
}
