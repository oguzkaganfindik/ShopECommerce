using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Fact : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
