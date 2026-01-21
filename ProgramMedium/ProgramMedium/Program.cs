// Úkol 1 - Funkce s návratovou hodnotou
// Opraveno: doplněny návratové hodnoty a a b
int Bigger(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

// Úkol 2 - Sudé nebo liché
// Opraveno: doplněn else s return false
bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Zadej číslo: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if (IsEven(n))
{
    Console.WriteLine("Sudé");
}
else
{
    Console.WriteLine("Liché");
}

// Úkol 3 - Odpočítávání
// Opraveno: vytvořena kompletní funkce s cyklem od n do 1
void Countdown(int n)
{
    for (int i = n; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}

Countdown(3);

// Úkol 4 - Součet čísel
// Opraveno: vytvořena kompletní funkce se součtem
int SumFromOne(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

// Úkol 5 - Mini menu
// Opraveno: kompletní menu s while cyklem a if/else podmínkami
bool running = true;
while (running)
{
    Console.WriteLine("1 - Pozdrav");
    Console.WriteLine("2 - Součet dvou čísel");
    Console.WriteLine("3 - Konec");
    Console.Write("Vyber možnost: ");
    
    int choice = int.Parse(Console.ReadLine() ?? "0");
    
    if (choice == 1)
    {
        Console.WriteLine("Ahoj! Vítej v programu!");
    }
    else if (choice == 2)
    {
        Console.Write("Zadej první číslo: ");
        int a = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Zadej druhé číslo: ");
        int b = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Součet: {a + b}");
    }
    else if (choice == 3)
    {
        Console.WriteLine("Ukončuji program...");
        running = false;
    }
    else
    {
        Console.WriteLine("Neplatná volba!");
    }
    
    Console.WriteLine();
}