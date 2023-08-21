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