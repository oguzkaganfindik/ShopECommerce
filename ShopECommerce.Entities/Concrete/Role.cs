using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Role : BaseEntity
    {
		public string Name { get; set; }
		public List<User> Users { get; set; }
    }
}
