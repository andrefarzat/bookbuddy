using Microsoft.EntityFrameworkCore;
using BookBuddy.Domain.Cars;
using BookBuddy.Domain.Customers;
using BookBuddy.Domain.Rentals;

namespace BookBuddy.Infra
{
    public class BookBuddyDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite database file in the project directory
            optionsBuilder.UseSqlite("Data Source=bookbuddy.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity mappings and relationships here if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
