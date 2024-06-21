namespace CarExpertise.Models
{
    public class TryVehicle
    {
        public int? Id { get; set; }
        public string? AracMarka { get; set; }
        public string? AracModel { get; set; }
        public string? MusteriAd { get; set; }
        public string? AracPlaka { get; set; }
        public string? Telefon { get; set; }
        public string? SaseNo { get; set; }
        public string? Email { get; set; }
        public int AracMarkaId { get; set; }
        public string? YakitTipi { get; set; }
        public int Yil { get; set; }
        public int AracKm { get; set; }
        public string? YedekAnahtar { get; set; }
        public string? Ucret { get; set; }
        public string? OdemeSekli { get; set; }
        public DateTime Tarih { get; set; }
    }
}
