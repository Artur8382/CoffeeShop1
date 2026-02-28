using System.Collections.Generic;

namespace CoffeeShop
{
    public class Topping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<OrderProductTopping> OrderProductToppings { get; set; }
    }
}
