namespace CarExpertise.Models
{
    public class VehicleModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? ParentId { get; set; }
        public bool IsActive { get; set; }
    }
}
