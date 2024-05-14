namespace ShopECommerce.WebUI.Services.Abstract
{
    public interface IEmailService
    {
        Task SendConfirmationEmail(string email, int code);
        Task SendPasswordResetEmail(string email, string resetLink);
        Task SendChangeMailConfirmationEmail(string newEmail, string changeMailLink);
        Task SendEmail(string receiverEmail, string subject, string body);
    }
}
