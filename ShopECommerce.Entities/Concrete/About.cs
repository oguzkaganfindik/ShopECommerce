using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class About : BaseEntity
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
