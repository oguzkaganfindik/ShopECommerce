using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
        public int? ConfirmCode { get; set; } // E-posta doğrulama kodu
        public int? ResetCode { get; set; } // Şifre sıfırlama kodu
        public int? ChangeMailCode { get; set; } // E-posta değiştirme kodu
        public string? NewEmail { get; set; } // Yeni e-posta adresi
        public bool EmailConfirmed { get; set; } = false;
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public Guid? UserGuid { get; set; } = Guid.NewGuid();
    }
}
