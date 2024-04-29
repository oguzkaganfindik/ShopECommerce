using ShopECommerce.Entities.Abstract;
using ShopECommerce.Entities.Enums;

namespace ShopECommerce.Entities.Concrete
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
