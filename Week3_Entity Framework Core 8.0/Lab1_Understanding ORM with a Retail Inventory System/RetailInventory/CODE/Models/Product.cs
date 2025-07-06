namespace RetailInventory.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }  
        public int CategoryId { get; set; }
        public int Stock { get; set; }

        public required Category Category { get; set; }
    }
}
