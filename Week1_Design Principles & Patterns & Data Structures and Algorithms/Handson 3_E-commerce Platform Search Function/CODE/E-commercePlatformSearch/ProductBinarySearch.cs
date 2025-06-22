using System.Collections.Generic;
using EcommercePlatformSearch.Models;

namespace EcommercePlatformSearch.Search
{
    public class ProductBinarySearch
    {
        public static Product? SearchByName(List<Product> products, string name)
        {
            int left = 0;
            int right = products.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = string.Compare(products[mid].ProductName, name, System.StringComparison.OrdinalIgnoreCase);
                if (cmp == 0) return products[mid];
                else if (cmp < 0) left = mid + 1;
                else right = mid - 1;
            }

            return null;
        }
    }
}
