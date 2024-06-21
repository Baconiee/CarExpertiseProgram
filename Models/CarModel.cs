namespace CarExpertise.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public int EkspertizId { get; set; }
        public int CompanyId { get; set; }
        public string? AracPlaka { get; set; }
        public string? SaseNo { get; set; }
        public string? AracMarka { get; set; }
        public int AracMarkaId { get; set; }
        public string? AracModel { get; set; }
        public int MusteriId { get; set; }
        public string? YakitTipi { get; set; }
        public string? Yil { get; set; }
        public string? AracKm { get; set; }
        public string? YedekAnahtar { get; set; }
        public int? Ucret { get; set; }
        public string? OdemeSekli { get; set; }
        public DateTime Tarih { get; set; }
    }
}
