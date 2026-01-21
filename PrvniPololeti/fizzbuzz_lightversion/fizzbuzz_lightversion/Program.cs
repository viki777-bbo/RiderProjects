Console.Write("Zadej číslo: ");
int cislo = int.Parse(Console.ReadLine());

Console.Write("Výsledek: ");

if (cislo % 3 == 0 && cislo % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (cislo % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (cislo % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(cislo);
}
