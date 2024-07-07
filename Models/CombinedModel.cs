namespace CarExpertise.Models
{
    public class CombinedModel
    {

        public CustomerModel CustomerData { get; set; }
        public ExpertiseModel ExpertiseData { get; set; }
        public VehicleModels VehicleData { get; set; }
        public TryVehicle TryVehicleData { get; set; }

    }
}
