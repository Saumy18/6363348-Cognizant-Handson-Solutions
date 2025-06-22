using System.Collections.Generic;
using EcommercePlatformSearch.Models;

namespace EcommercePlatformSearch.Search
{
    public class ProductLinearSearch
    {
        public static Product? SearchByName(List<Product> products, string name)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(name, System.StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }
    }
}
