using Microsoft.EntityFrameworkCore; // ✅ Required
using RetailStoreDB.Models;

namespace RetailStoreDB
{
    // ✅ Correctly inherit from DbContext
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=RetailStoreDB;Trusted_Connection=True;",
                options => options.EnableRetryOnFailure()
            );
        }
    }
}
