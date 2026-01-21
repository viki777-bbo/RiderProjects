Console.Write("Zadej známku (1–5): ");
int grade = int.Parse(Console.ReadLine());
switch (grade)
{
    case 1:
        Console.WriteLine("Výborně");
        break;
    case 2:
        Console.WriteLine("Chvalitebně");
        break;
    case 3:
        Console.WriteLine("Dobře");
        break;
    case 4:
        Console.WriteLine("Dostatečně");
        break;
    case 5:
        Console.WriteLine("Nedostatečně");
        break;
    default:
        Console.WriteLine("Neplatná známka");
        break;
}