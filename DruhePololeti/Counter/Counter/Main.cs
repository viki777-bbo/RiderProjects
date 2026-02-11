class Program
{
    static void Main()
    {
        Product p1 = new Product("Kokosove piti", 50);
        Product p2 = new Product("Ovesne vlocky", 25);
        Product p3 = new Product("Mozarella", 32);

        Product.PrintWarehouseSummary();
    }
}