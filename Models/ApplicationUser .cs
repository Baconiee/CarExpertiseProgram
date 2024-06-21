using Microsoft.AspNetCore.Identity;

namespace CarExpertise.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string TaxNumber { get; set; }
        public string Office { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CompanyId { get; set; }
    }
}
