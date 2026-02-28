namespace CoffeeShop
{
    public class LoyaltyPoints
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Points { get; set; }

        public User User { get; set; }

        public void AddPoints(User user, decimal amountSpent)
        {
            Points += user.Type == UserType.Gold
                ? (int)(amountSpent * 2)
                : (int)amountSpent;
        }
    }
}
