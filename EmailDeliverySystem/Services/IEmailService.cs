using EmailDeliverySystem.API.Models;

namespace EmailDeliverySystem.API.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailRequest emailRequest);
    }

}
