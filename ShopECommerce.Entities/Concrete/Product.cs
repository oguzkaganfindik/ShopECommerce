using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int SubCategoryId { get; set; }
        public string? ProductTitle { get; set; }
        public decimal? Weight { get; set; }
        public string? CountryOfOrigin { get; set; }
        public string? Quality { get; set; }
        public string? Сheck { get; set; }
        public decimal? MinWeight { get; set; }

        // Relational Property
        public SubCategory SubCategory { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}
