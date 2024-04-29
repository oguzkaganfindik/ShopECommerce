using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        // Relational Property

        public List<Product> Products { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
