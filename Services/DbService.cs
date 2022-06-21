using Course_work_Cash_Dispatcher.Models;
using Microsoft.EntityFrameworkCore;

namespace BusStation.Services
{
    public class DbService : DbContext
    {
        public DbService()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BusStation.db");
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Dispatcher> Dispatchers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
