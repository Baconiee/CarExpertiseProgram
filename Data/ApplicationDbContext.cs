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
        public DbSet<CustomerModel> CustomerTable { get; set; }
        public DbSet<ExpertiseModel> ExpertiseTable { get; set; }
        public DbSet<TryVehicle> Trys { get; set; }
        public DbSet<CarModel> CarModelTable { get; set; }
        public DbSet<ExpertiseTemplate> ExpertiseTemplateTable { get; set; }
    }
}
