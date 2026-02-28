// See https://aka.ms/new-console-template for more information
public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime Timestamp { get; set; }

    //2.2
    public decimal CalculateFinalPrice()
    {
        var total = OrderItems?.Sum(oi => oi.UnitPrice * oi.Quantity) ?? 0;
        return total >= 500 ? total * 0.90m : total;
    }

    public User User { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}













