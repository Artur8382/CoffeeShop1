// See https://aka.ms/new-console-template for more information
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public int AddressId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Address Address { get; set; }
    public ICollection<Order> Orders { get; set; }
}