// See https://aka.ms/new-console-template for more information
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Category Parent { get; set; }
    public ICollection<Category> Children { get; set; }
    public ICollection<Product> Products { get; set; }
}

