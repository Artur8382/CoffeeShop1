namespace CoffeeShop
{
    public class OrderProductTopping
    {
        public int Id { get; set; }
        public int OrderProductId { get; set; }
        public int ToppingId { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public OrderProduct OrderProduct { get; set; }
        public Topping Topping { get; set; }
    }
}
