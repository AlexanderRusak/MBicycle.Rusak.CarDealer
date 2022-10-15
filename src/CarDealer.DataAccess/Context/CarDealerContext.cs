using CarDealer.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.DataAccess.Context
{
    public sealed class CarDealerContext : DbContext
    {
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarModelName> CarModelNames { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<DealerCar> DealerCars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\LocalDB;Database=CarDealerDb;Trusted_Connection=true");
        }

    }
}
