// Step 1: Define an interface for discount strategy
public interface IDiscountStrategy
{
    double ApplyDiscount(double price);
}

// Step 2: Implement different discount strategies
public class ElectronicsDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price - (price * 0.10);  // 10% discount for Electronics
    }
}

public class ClothingDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price - (price * 0.20);  // 20% discount for Clothing
    }
}

public class NoDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price;  // No discount
    }
}

// Step 3: Modify the Product class to use the strategy pattern
public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    private IDiscountStrategy _discountStrategy;

    // Constructor allows setting a discount strategy
    public Product(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    // Method to get the price after applying the discount
    public double GetPriceAfterDiscount()
    {
        return _discountStrategy.ApplyDiscount(Price);
    }
}
public class Program
{
    public static void Main()
    {
        // Creating products with different discount strategies
        Product laptop = new Product(new ElectronicsDiscount());
        laptop.Name = "Laptop";
        laptop.Price = 1000;

        Product tShirt = new Product(new ClothingDiscount());
        tShirt.Name = "T-Shirt";
        tShirt.Price = 50;

        Product book = new Product(new NoDiscount());
        book.Name = "Book";
        book.Price = 20;

        // Print prices after applying discounts
        Console.WriteLine($"Price of {laptop.Name} after discount: {laptop.GetPriceAfterDiscount()}");
        Console.WriteLine($"Price of {tShirt.Name} after discount: {tShirt.GetPriceAfterDiscount()}");
        Console.WriteLine($"Price of {book.Name} after discount: {book.GetPriceAfterDiscount()}");
    }
}
