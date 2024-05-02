using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        // Relational Property
        public List<Product> Products { get; set; }
    }
}
