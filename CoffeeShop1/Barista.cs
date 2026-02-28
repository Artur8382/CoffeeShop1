using System.Collections.Generic;

namespace CoffeeShop
{
    public class Barista
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
