using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        // Relational Property
        public List<SubCategory> SubCategories { get; set; }
    }
}
