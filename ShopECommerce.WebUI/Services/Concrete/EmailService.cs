using MailKit.Net.Smtp;
using MimeKit;
using ShopECommerce.WebUI.Services.Abstract;

namespace ShopECommerce.WebUI.Services.Concrete
{
    public class EmailService : IEmailService
    {
        public async Task SendConfirmationEmail(string emailAddress, int code)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("ShopECommerce Admin", "shopecommerceapp@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", emailAddress));

            mimeMessage.Subject = "ShopECommerce Onay Kodu";
            mimeMessage.Body = new TextPart("plain")
            {
                Text = $"Kayıt işlemini gerçekleştirmek için onay kodunuz: {code}"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("shopecommerceapp@gmail.com", "xham outs ozqj tgjp");
                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendPasswordResetEmail(string email, string resetLink)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("ShopECommerce Admin", "shopecommerceapp@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", email));

            mimeMessage.Subject = "ShopECommerce Şifre Sıfırlama";
            mimeMessage.Body = new TextPart("plain")
            {
                Text = $"Şifrenizi sıfırlamak için aşağıdaki bağlantıya tıklayın: {resetLink}"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("shopecommerceapp@gmail.com", "xham outs ozqj tgjp");
                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendChangeMailConfirmationEmail(string newEmail, string changeMailLink)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("ShopECommerce Admin", "shopecommerceapp@gmail.com"));
            message.To.Add(new MailboxAddress("User", newEmail));
            message.Subject = "ShopECommerce Mail Adresi Değiştirme Onayı";
            message.Body = new TextPart("plain")
            {
                Text = $"Mail adresinizi değiştirmek için lütfen aşağıdaki linke tıklayın: {changeMailLink}"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("shopecommerceapp@gmail.com", "xham outs ozqj tgjp");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}