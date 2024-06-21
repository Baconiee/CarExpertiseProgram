using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace CarExpertise.Models
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // E-posta gönderme iþlevselliðini burada uygulayýn.
            // Bu örnekte, gerçek e-posta gönderme iþlemi yapýlmamaktadýr.
            return Task.CompletedTask;
        }
    }
}
