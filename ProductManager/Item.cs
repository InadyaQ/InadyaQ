namespace ProductManager;

public class Item : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public decimal Price { get; set; }
    public ProductCategory Category { get; set; }

    public Item(int id, string name, decimal price, ProductCategory category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"\tName product: {Name} \tPrice product: {Price} \tId product: {Id} \tProduct Category: {
            Category}");
    }
}
