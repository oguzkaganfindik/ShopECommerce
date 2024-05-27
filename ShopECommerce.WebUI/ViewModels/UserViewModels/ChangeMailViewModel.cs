using System.ComponentModel.DataAnnotations;

namespace ShopECommerce.WebUI.ViewModels.UserViewModels
{
    public class ChangeMailViewModel
    {
        [Required(ErrorMessage = "E-posta adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Yeni e-posta adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz yeni e-posta adresi.")]
        public string NewEmail { get; set; } // Yeni mail adresi
        public int ChangeMailCode { get; set; } // Mail adresi değiştirme onay kodu
        public string ChangeMailLink { get; set; }
    }
}
