namespace ShopECommerce.WebUI.Services.Abstract
{
    public interface IEmailService
    {
        Task SendConfirmationEmailAsync(string email, int code);
        Task SendPasswordResetEmailAsync(string email, string resetLink);
        Task SendChangeMailConfirmationEmailAsync(string newEmail, string changeMailLink);
        Task SendEmailAsync(string receiverEmail, string subject, string body);
    }
}
