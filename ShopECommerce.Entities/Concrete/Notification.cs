using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Notification : BaseEntity
    {
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }
}
