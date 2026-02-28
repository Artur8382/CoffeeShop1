// See https://aka.ms/new-console-template for more information
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public decimal Weight { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Category Category { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}