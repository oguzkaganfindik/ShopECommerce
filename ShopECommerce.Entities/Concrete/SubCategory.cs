using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class SubCategory : BaseEntity
    {
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Relational Property
        public List<Product>? Products { get; set; }
    }
}
