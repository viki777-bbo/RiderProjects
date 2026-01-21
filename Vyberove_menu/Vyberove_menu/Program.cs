Console.WriteLine("Vyber si z menu:");
Console.WriteLine("1. Vklad na účet");
Console.WriteLine("2. Výběr z účtu");
Console.WriteLine("3. Zobrazení zůstatku");

Console.Write("Zadej číslo: ");
int volba = int.Parse(Console.ReadLine());

if (volba == 1)
{
    Console.WriteLine("Budete vkládat peníze na účet");
}
else if (volba == 2)
{
    Console.WriteLine("Budete si vybírat z účtu");
}
else if (volba == 3)
{
    Console.WriteLine("Budete zobrazovat zůstatek");
}
else
{
    Console.WriteLine("Neplatná volba");
}