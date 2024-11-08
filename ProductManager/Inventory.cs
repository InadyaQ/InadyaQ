namespace ProductManager;

public class Inventory
{
    private List<IProduct> items = new List<IProduct>();
    public void AddProduct(IProduct product)
    {
        items.Add(product);
        Console.WriteLine($"Product {product.Name} added to inventory");
    }

    public bool RemoveProduct(int id)
    {
        var item = FindProduct(id);
        if (item != null)
        {
            items.Remove(item);
            Console.WriteLine($"Product {item.Name} removed from inventory.");
            return true;
        }
        Console.WriteLine("Product not found.");
        return false;
    }

    public IProduct? FindProduct(int id)
    {
        return items.FirstOrDefault(i => i.Id == id);
    }

    public void DisplayAllProducts()
    {
        if (items.Any())
        {
            foreach (var product in items)
            {
                product.DisplayInfo();
            }
            
        }
        else
        {
            Console.WriteLine("No products in the inventory.");
        }
    }
}