using EmailDeliverySystem.API.Models;
using System.Net.Mail;
using System.Net;

namespace EmailDeliverySystem.API.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _smtpHost;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;

        public EmailService(IConfiguration configuration)
        {
            _smtpHost = configuration["EmailSettings:SmtpHost"];
            _smtpPort = int.Parse(configuration["EmailSettings:SmtpPort"]);
            _smtpUsername = configuration["EmailSettings:SmtpUsername"];
            _smtpPassword = configuration["EmailSettings:SmtpPassword"];
        }

        public async Task SendEmailAsync(EmailRequest emailRequest)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(_smtpUsername),
                Subject = emailRequest.Subject,
                Body = emailRequest.Body,
                IsBodyHtml = true
            };

            mailMessage.To.Add(emailRequest.To);

            using (var smtpClient = new SmtpClient(_smtpHost, _smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                smtpClient.EnableSsl = true;
                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }

}
