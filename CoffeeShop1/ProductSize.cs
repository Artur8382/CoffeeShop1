namespace CoffeeShop
{
    public class ProductSize
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Size { get; set; } // e.g. "Small", "Medium", "Large"
        public decimal Price { get; set; }

        public Product Product { get; set; }
    }
}
