class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    private static int _totalProductsCount = 0;
    private static double _totalValue = 0;
    
    public Product(string name, double price)
    {
        Name = name;
        Price = price;

        _totalProductsCount++;
        _totalValue += price;
    }

    public static void PrintWarehouseSummary()
    {
        Console.WriteLine(
            $"Celkem produktů: {_totalProductsCount}, Celková hodnota skladu: {_totalValue}");
    }
}

            