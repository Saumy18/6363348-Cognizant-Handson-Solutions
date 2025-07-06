using System;
using System.Linq;
using System.Threading.Tasks;
using RetailStoreDB.Models;

namespace RetailStoreDB
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // ✅ Change the condition to only insert if these specific categories don't exist
                if (!context.Categories.Any(c => c.Name == "Electronics V2" || c.Name == "Groceries V2"))
                {
                    // ✅ New Category Names to force insertion
                    var electronics = new Category { Name = "Electronics V2" };
                    var groceries = new Category { Name = "Groceries V2" };

                    await context.Categories.AddRangeAsync(electronics, groceries);

                    var product1 = new Product
                    {
                        Name = "Laptop Pro",
                        Price = 85000,
                        Category = electronics
                    };

                    var product2 = new Product
                    {
                        Name = "Rice Bag Premium",
                        Price = 1500,
                        Category = groceries
                    };

                    await context.Products.AddRangeAsync(product1, product2);
                    await context.SaveChangesAsync();
                }

                var products = context.Products.ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                }
            }
        }
    }
}
