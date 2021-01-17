using MimeKit;
using PassGuard.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGuard.Models
{
    public static class EmailHandler
    {
        public static void SendEmail(string toName, string toEmail, string content)
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
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate("kitric.noreply@gmail.com", Settings.Default.NoReply);
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }
    }
}
