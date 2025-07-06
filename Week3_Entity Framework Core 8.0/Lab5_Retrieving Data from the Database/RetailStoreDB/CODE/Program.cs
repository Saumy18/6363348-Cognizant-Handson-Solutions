using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Required for async EF Core methods
using RetailStoreDB.Models; // Your models namespace

namespace RetailStoreDB
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // For EF Core 8 use 'await using', for EF Core 6 use 'using'
            await using var context = new AppDbContext();

            // ✅ 1. Retrieve All Products
            var products = await context.Products.ToListAsync();
            Console.WriteLine("\nAll Products:");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
            }

            // ✅ 2. Find Product by ID
            var product = await context.Products.FindAsync(1);
            if (product != null)
            {
                Console.WriteLine($"\nFound by ID: {product.Name} - ₹{product.Price}");
            }
            else
            {
                Console.WriteLine("\nProduct with ID 1 not found.");
            }

            // ✅ 3. First Product with Price > 50000
            var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            if (expensive != null)
            {
                Console.WriteLine($"\nExpensive Product: {expensive.Name} - ₹{expensive.Price}");
            }
            else
            {
                Console.WriteLine("\nNo expensive product found.");
            }
        }
    }
}
