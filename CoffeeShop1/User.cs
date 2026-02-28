using System.Collections.Generic;

namespace CoffeeShop
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserType Type { get; set; }

        public LoyaltyPoints LoyaltyPoints { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    public enum UserType
    {
        Regular,
        Gold
    }
}
