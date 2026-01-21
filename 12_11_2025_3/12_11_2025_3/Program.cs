string cesta = "data.txt";

if (!File.Exists(cesta))
{
    StreamReader sr = new StreamReader("data.txt");
    string line = sr.ReadLine();

    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }

    sr.Close();

    StreamWriter sw = new StreamWriter(cesta);
    
    sw.WriteLine("\nHello!");
    sw.WriteLine("dobry den");
    for (int i = 0; i < 100; i++)
    {
        sw.WriteLine($"index: {i}");
    }
    
    sw.Close();
}
