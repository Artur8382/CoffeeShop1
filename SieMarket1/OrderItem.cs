// See https://aka.ms/new-console-template for more information
public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }  
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }  
    public DateTime Timestamp { get; set; }

    public Order Order { get; set; }
    public Product Product { get; set; }
}









