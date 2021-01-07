using Microsoft.EntityFrameworkCore;
using TruckRegistration.Domain;

namespace TruckRegistration.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // if (!optionsBuilder.IsConfigured)
            // {
            //     optionsBuilder.UseSqlite("Data Source=ModelTruckControl.db");
            // }
        }

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<TruckModel> TruckModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Truck>().HasKey(x => x.Id);
            modelBuilder.Entity<TruckModel>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}