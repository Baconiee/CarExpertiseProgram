using CarExpertise.Models;
using Microsoft.EntityFrameworkCore;

namespace CarExpertise.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<VehicleModel> VehicleModels { get; set; }
    }
}
