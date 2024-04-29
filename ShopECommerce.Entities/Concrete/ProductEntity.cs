using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
        public string ImagePath { get; set; }

        public int CategoryId { get; set; }

        // Relational Property

        public CategoryEntity Category { get; set; }
    }
}
