using System;
using System.Linq;
using RetailStoreDB.Models;

namespace RetailStoreDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                if (!context.Categories.Any())
                {
                    var category = new Category { Name = "Groceries" };
                    context.Categories.Add(category);
                    context.SaveChanges();

                    var product = new Product
                    {
                        Name = "Sugar",
                        Price = 45.50M,
                        CategoryId = category.Id,
                        Category = category
                    };
                    context.Products.Add(product);
                    context.SaveChanges();
                }

                foreach (var product in context.Products)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                }
            }
        }
    }
}
