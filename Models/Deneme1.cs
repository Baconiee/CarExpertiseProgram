using System.ComponentModel.DataAnnotations;

namespace CarExpertise.Models
{
    public class Deneme1
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string? MusteriAd { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public int AracMarkaId { get; set; }
    }
}
