public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public int ProductTypeId { get; set; }
    public DateTime DateStocked { get; set; }
    // auto-implemented property
    public int DaysOnShelf //calculated property
    {
        get
        {
            TimeSpan timeOnShelf = DateTime.Now - DateStocked;
            return timeOnShelf.Days;
        }
    }


    public Product(string name, decimal price, bool isAvailable, int productTypeId, DateTime dateStocked)
    {
        Name = name;
        Price = price;
        IsAvailable = isAvailable;
        ProductTypeId = productTypeId;
        DateStocked = dateStocked;
    }



}

/* 
public class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public List<Product> GetProductsByType(int productTypeId)
    {
        return products.Where(p => p.ProductTypeId == productTypeId).ToList();
    }
}
 */