/*
if (File.Exists(path: "data.txt"))
{
    StreamReader sr = new  StreamReader("data.txt");

    string line =  sr.ReadLine();

    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();

    }
    sr.Close();
}

if (File.Exists(path: "data.txt"))
{
    StreamWriter sw = new  StreamWriter("data.txt");
    sw.WriteLine("Hello World!");
    sw.WriteLine("třetí řádek");
    sw.Close();
}
*/


string path = "data.txt";

int celkovyVek = 0;
int zaci = 0;

if (File.Exists(path))
{
    StreamReader sr = new StreamReader(path);

    string text = sr.ReadLine();

    while (text != null)
    { 
        string[] casti = text.Split(";");
        Console.WriteLine(casti[0] + " " + casti[1]);

        int vek = int.Parse(casti[3]);
        zaci = 1 + zaci;
        celkovyVek = vek + celkovyVek;

        text = sr.ReadLine();

    }

    sr.Close();

    double prumer = celkovyVek / (double)zaci;
    Console.WriteLine("Průměr je: " + prumer);

    StreamWriter sw = new StreamWriter(path, true);
    sw.WriteLine("Průměr je: " + prumer);

    sw.WriteLine("Celkový počet žáků:" + zaci);
    sw.WriteLine("Celkový věk: " +  celkovyVek);
    sw.WriteLine("Průměr žáků: " + prumer);

    sw.Close();
}
else
{
    Console.WriteLine("NENÍ SOUBOR!!!");
}