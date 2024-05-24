using MailKit.Net.Smtp;
using MimeKit;
using ShopECommerce.WebUI.Services.Abstract;

namespace ShopECommerce.WebUI.Services.Concrete
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendConfirmationEmailAsync(string emailAddress, int code)
        {
            var emailSettings = _configuration.GetSection("EmailSettings");
            var smtpServer = emailSettings["SmtpServer"];
            var port = int.Parse(emailSettings["Port"]);
            var username = emailSettings["Username"];
            var password = emailSettings["Password"];
            var fromAddress = emailSettings["FromAddress"];

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
                await client.ConnectAsync(smtpServer, port, false);
                await client.AuthenticateAsync(username, password);
                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendPasswordResetEmailAsync(string email, string resetLink)
        {
            var emailSettings = _configuration.GetSection("EmailSettings");
            var smtpServer = emailSettings["SmtpServer"];
            var port = int.Parse(emailSettings["Port"]);
            var username = emailSettings["Username"];
            var password = emailSettings["Password"];
            var fromAddress = emailSettings["FromAddress"];

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
                await client.ConnectAsync(smtpServer, port, false);
                await client.AuthenticateAsync(username, password);
                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
        }


        public async Task SendChangeMailConfirmationEmailAsync(string newEmail, string changeMailLink)
        {
            var emailSettings = _configuration.GetSection("EmailSettings");
            var smtpServer = emailSettings["SmtpServer"];
            var port = int.Parse(emailSettings["Port"]);
            var username = emailSettings["Username"];
            var password = emailSettings["Password"];
            var fromAddress = emailSettings["FromAddress"];

            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("ShopECommerce Admin", "shopecommerceapp@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", newEmail));
            mimeMessage.Subject = "ShopECommerce Mail Adresi Değiştirme Onayı";
            mimeMessage.Body = new TextPart("plain")
            {
                Text = $"Mail adresinizi değiştirmek için lütfen aşağıdaki linke tıklayın: {changeMailLink}"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(smtpServer, port, false);
                await client.AuthenticateAsync(username, password);
                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendEmailAsync(string receiverEmail, string subject, string body)
        {
            var emailSettings = _configuration.GetSection("EmailSettings");
            var smtpServer = emailSettings["SmtpServer"];
            var port = int.Parse(emailSettings["Port"]);
            var username = emailSettings["Username"];
            var password = emailSettings["Password"];

            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("ShopECommerce", "shopecommerceapp@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", receiverEmail));
            mimeMessage.Subject = subject;

            var bodybuilder = new BodyBuilder();
            bodybuilder.HtmlBody = body; 
            mimeMessage.Body = bodybuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(smtpServer, port, false);
                await client.AuthenticateAsync(username, password);
                await client.SendAsync(mimeMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}
