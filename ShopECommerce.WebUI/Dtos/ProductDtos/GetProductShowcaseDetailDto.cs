namespace ShopECommerce.WebUI.Dtos.ProductDtos
{
    public class GetProductShowcaseDetailDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryName { get; set; }
        public string? ProductTitle { get; set; }
        public decimal? Weight { get; set; }
        public string? CountryOfOrigin { get; set; }
        public string? Quality { get; set; }
        public string? Сheck { get; set; }
        public decimal? MinWeight { get; set; }
        public bool Status { get; set; }
    }
}
