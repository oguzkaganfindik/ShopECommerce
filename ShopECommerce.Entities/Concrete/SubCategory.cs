using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class SubCategory : BaseEntity
    {
		public string Name { get; set; }
        public virtual Category Category { get; set; }
		public int CategoryId { get; set; }

    }
}
