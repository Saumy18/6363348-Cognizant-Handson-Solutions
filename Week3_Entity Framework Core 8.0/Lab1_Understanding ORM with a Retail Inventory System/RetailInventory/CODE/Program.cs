using System;
using RetailInventory.Models;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new RetailContext())
            {
                
                var category = new Category { Name = "Electronics" };
                context.Categories.Add(category);
                context.SaveChanges();

                
                var product = new Product
                {
                    Name = "Laptop",
                    CategoryId = category.CategoryId,
                    Stock = 50,
                    Category = category // ✅ Fixed
                };

                context.Products.Add(product);
                context.SaveChanges();

                
                foreach (var prod in context.Products)
                {
                    Console.WriteLine($"Product: {prod.Name}, Stock: {prod.Stock}");
                }
            }
        }
    }
}
