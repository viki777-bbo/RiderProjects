Console.Write("Zadej heslo:");
string heslo = Console.ReadLine();
string SpravneHeslo = "tajne";

if (heslo == SpravneHeslo)
{
    Console.WriteLine("Přístup povolen");
}
else
{
    Console.WriteLine("Přístup zamítnut");
}