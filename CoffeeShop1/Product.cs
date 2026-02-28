using System.Collections.Generic;

namespace CoffeeShop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductSize> Sizes { get; set; }
    }
}
