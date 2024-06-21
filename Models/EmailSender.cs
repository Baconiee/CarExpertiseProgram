using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace CarExpertise.Models
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // E-posta g�nderme i�levselli�ini burada uygulay�n.
            // Bu �rnekte, ger�ek e-posta g�nderme i�lemi yap�lmamaktad�r.
            return Task.CompletedTask;
        }
    }
}
