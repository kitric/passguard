using MimeKit;
using PassGuard.Properties;
using System.Threading.Tasks;

namespace PassGuard.Models
{
    public static class EmailHandler
    {
        public static async Task SendEmailAsync(string toName, string toEmail, string content)
        {
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = content;

            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("Kitric Software", "kitric.noreply@gmail.com"));
            mailMessage.To.Add(new MailboxAddress(toName, toEmail));
            mailMessage.Subject = "PassGuard - Master Password";
            mailMessage.Body = bodyBuilder.ToMessageBody();

            using (var smtpClient = new MailKit.Net.Smtp.SmtpClient())
            {
                await smtpClient.ConnectAsync("smtp.gmail.com", 465, true);
                await smtpClient.AuthenticateAsync("kitric.noreply@gmail.com", Settings.Default.NoReply);
                await smtpClient.SendAsync(mailMessage);
                await smtpClient.DisconnectAsync(true);
            }
        }
    }
}
