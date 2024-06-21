using CarExpertise.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarExpertise.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<VehicleModels> VehicleModelss { get; set; }
        public DbSet<CustomerModel> CustomerModels { get; set; }
        public DbSet<ExpertiseModel> ExpertiseModels { get; set; }
        public DbSet<Deneme1> Deneme1s { get; set; }
        public DbSet<Deneme2> Deneme2s { get; set; }
        public DbSet<TryVehicle> Trys { get; set; }
        public DbSet<CarModel> CarModelTable { get; set; }
        public DbSet<EkspertizSablon> EkspertizSablonTable { get; set; }
    }
}
