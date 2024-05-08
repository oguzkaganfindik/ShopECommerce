using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class ShopTable : BaseEntity
    {
        public string Name { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}
