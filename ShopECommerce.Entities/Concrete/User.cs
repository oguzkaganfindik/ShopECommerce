using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string Description { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
