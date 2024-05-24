using ShopECommerce.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopECommerce.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public int BasketItemId { get; set; }
        public BasketItem BasketItem { get; set; }

        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}