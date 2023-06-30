using Microsoft.EntityFrameworkCore;
using TravelEasy.EV.DataLayer.Models;

namespace TravelEasy.EV.DataLayer
{
    public class ElectricVehiclesContext : DbContext
    {
        public DbSet<ElectricVehicle> ElectricVehicles { get; set;}

        public ElectricVehiclesContext(DbContextOptions<ElectricVehiclesContext> options)
           : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EasyTravel;Trusted_Connection=True");
        //}
    }
}