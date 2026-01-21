Console.Write("Zadej první číslo: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Zadej operaci (+, -, *, /):");
string operace = Console.ReadLine();

Console.Write("Zadej druhé číslo:");
int b = int.Parse(Console.ReadLine());

int vysledek = 0;

if (operace == "+") 
{
    vysledek = a + b; 
}
else if (operace == "-")
{
    vysledek = a - b;
}
else if (operace == "*")
{
    vysledek = a * b;
}
else if (operace == "/")
{
    if (b == 0)
    {
        Console.WriteLine("Nepovolená operace");
        return;
    }
    vysledek = a / b;
}

Console.WriteLine("Výsledek: " + vysledek);


