List<ProductType> productTypes = new List<ProductType>()
    {
        new ProductType(1, "Apparel"),
        new ProductType(2, "Potions"),
        new ProductType(3, "Enchanted Objects"),
        new ProductType(4, "Wands")
    };

List<Product> products = new List<Product>
    {
        new Product("Wizard Robe", 50.99M, true, 1), // Apparel
        new Product("Healing Potion", 10.49M, true, 2), // Potions
        new Product("Levitating Broomstick", 150.00M, false, 4), // Wands
        new Product("Invisibility Cloak", 200.00M, true, 3), // Enchanted Objects
        new Product("Fireproof Gloves", 30.00M, true, 1), // Apparel
        new Product("Love Potion", 25.99M, true, 2), // Potions
        new Product("Crystal Ball", 75.00M, true, 3), // Enchanted Objects
        new Product("Dragon Scale Wand", 120.00M, true, 4), // Wands
        new Product("Phoenix Feather Wand", 130.00M, false, 4), // Wands
        new Product("Frog Choir Ensemble", 40.00M, true, 1) // Apparel
    };


string greeting = @">>>
Welcome to ReductioAbsurdum
Your source for magical supplies";

Console.Clear();
Console.WriteLine(greeting);

string choice = null;
while (choice != "0")
{
    Console.WriteLine("\nPress any key to enter the main menu...");
    Console.ReadKey();
    Console.Clear();

    InitialOptions();

    choice = Console.ReadLine().Trim();
    switch (choice)
    {
        case "0":
            Console.WriteLine("Goodbye!");
            break;
        case "1":
            ListProducts();
            break;
        case "2":
            AddProduct();
            break;
        case "3":
            // Implement the DeleteProduct method
            // DeleteProduct();
            break;
        case "4":
            // Implement the UpdateProduct method
            // UpdateProduct();
            break;
        default:
            Console.WriteLine($"Choose a valid option from the menu!");
            break;
    }
}

void InitialOptions()
{
    Console.WriteLine(@">>>
                Choose an option:
                0. Exit
                1. View All Products
                2. Add a Product to Inventory
                3. Delete a Product from Inventory
                4. Update Product Details");
}

void ListProducts()
{
    Console.WriteLine(@">>>
                Products Inventory:");

    foreach (Product product in products)
    {
        Console.WriteLine($"Name: {product.Name}, Price: {product.Price:C}, Available: {(product.IsAvailable ? "Yes" : "No")}, Type: {productTypes[product.ProductTypeId - 1].Name}");
    }
}

void AddProduct()
{
    Console.Clear();

    Console.Write("Enter product name: ");
    string name = Console.ReadLine();

    decimal price = 0;
    while (price <= 0)
    {
        Console.Write("Enter product price: ");
        if (decimal.TryParse(Console.ReadLine(), out price) && price > 0)
        {
            break;
        }
        Console.WriteLine("Invalid input. Please enter a valid positive price.");
    }

    bool isAvailable = false;
    while (true)
    {
        Console.Write("Is the product available? (yes/no): ");
        string availabilityInput = Console.ReadLine().Trim().ToLower();
        if (availabilityInput == "yes")
        {
            isAvailable = true;
            break;
        }
        else if (availabilityInput == "no")
        {
            isAvailable = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
        }
    }

    Console.WriteLine("Select a product type:");
    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Name}");
    }

    int selectedProductTypeId = 0;
    while (selectedProductTypeId < 1 || selectedProductTypeId > productTypes.Count)
    {
        Console.Write("Enter the number corresponding to the product type: ");
        if (int.TryParse(Console.ReadLine(), out selectedProductTypeId) && selectedProductTypeId >= 1 && selectedProductTypeId <= productTypes.Count)
        {
            break;
        }
        Console.WriteLine("Invalid input. Please enter a valid product type number.");
    }

    Product newProduct = new Product(name, price, isAvailable, selectedProductTypeId);
    products.Add(newProduct);

    Console.Clear();
    Console.WriteLine("Product added successfully!");
    Console.WriteLine("New Product Details:");
    Console.WriteLine($"Name: {newProduct.Name}, Price: {newProduct.Price:C}, Available: {(newProduct.IsAvailable ? "Yes" : "No")}, Type: {productTypes[newProduct.ProductTypeId - 1].Name}");

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();
}

