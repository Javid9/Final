using JobSearchEndProject.Interfaces;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Services
{
    public class EmailSubscribe : IEmailService
    {
        public async Task SendEmailAsync(List<string> email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Joobsy Saytinin Admini", "c.dadashov@inbox.ru"));
            foreach (var item in email)
            {
                emailMessage.To.Add(new MailboxAddress("", item));
            }
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", 465, true);
                await client.AuthenticateAsync("c.dadashov@inbox.ru", "y)iNytUUyK32");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }


        }
    }
}
