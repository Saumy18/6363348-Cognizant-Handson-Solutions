using System;
using System.Collections.Generic;
using EcommercePlatformSearch.Models;
using EcommercePlatformSearch.Search;

namespace EcommercePlatformSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Shirt", "Clothing"),
                new Product(103, "Watch", "Accessories"),
                new Product(104, "Phone", "Electronics"),
                new Product(105, "Shoes", "Footwear")
            };

            // Linear Search
            Console.WriteLine("🔍 Linear Search:");
            var result1 = ProductLinearSearch.SearchByName(products, "Watch");
            Console.WriteLine(result1 != null
                ? $"Product found: {result1.ProductName} - {result1.Category}"
                : "Product not found");

            // Sort before binary search
            products.Sort((p1, p2) => string.Compare(p1.ProductName, p2.ProductName, StringComparison.OrdinalIgnoreCase));

            // Binary Search
            Console.WriteLine("\n🔍 Binary Search:");
            var result2 = ProductBinarySearch.SearchByName(products, "Watch");
            Console.WriteLine(result2 != null
                ? $"Product found: {result2.ProductName} - {result2.Category}"
                : "Product not found");
        }
    }
}
