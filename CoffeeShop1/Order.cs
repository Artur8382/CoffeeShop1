using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeShop
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BaristaId { get; set; }
        public DateTime Timestamp { get; set; }

        public decimal Price => OrderProducts?.Sum(op =>
            op.Price *op.Quantity + op.OrderProductToppings.Sum(t => t.Price*t.Quantity)) ?? 0;

        public required User User { get; set; }
        public required Barista Barista { get; set; }
        public required ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
