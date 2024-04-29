using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class MoneyCase : BaseEntity
    {
        public decimal TotalAmount { get; set; }
    }
}
