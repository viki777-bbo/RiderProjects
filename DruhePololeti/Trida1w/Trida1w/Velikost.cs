class Program
{
    static void Main(string[] args)
    {
        Wall wall1 = new Wall(3.5f, 5.0f, "cihla");
        Wall wall2 = new Wall(2.8f, 4.2f, "beton");
        
        wall1.PrintInfo();
        wall2.PrintInfo();
        
        float plocha1 = wall1.GetSurface();
        Console.WriteLine("Plocha první zdi: " + plocha1);
    }
}