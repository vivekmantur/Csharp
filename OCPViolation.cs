public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    // Method that applies a discount based on product type
    public double GetPriceAfterDiscount(string productType)
    {
        if (productType == "Electronics")
        {
            return Price - (Price * 0.10);  // 10% discount for Electronics
        }
        else if (productType == "Clothing")
        {
            return Price - (Price * 0.20);  // 20% discount for Clothing
        }
        else
        {
            return Price;  // No discount for other products
        }
    }
}
