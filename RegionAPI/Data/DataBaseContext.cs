using Microsoft.EntityFrameworkCore;
using RegionAPI.Models;
using RegionAPI.ModelsConfigs;

namespace RegionAPI.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
           : base(options)
        {

        }

        public DbSet<MyModel> MyModels { get; set; }
        public DbSet<CountryModel> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}