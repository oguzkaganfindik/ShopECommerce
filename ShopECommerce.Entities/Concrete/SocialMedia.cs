using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class SocialMedia : BaseEntity
    {
        public string Title { get; set; }
        public string Cls { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
