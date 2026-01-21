// Úkol 1 - Oprav funkci
void Greet()
{
    Console.WriteLine("Ahoj!");
}
Greet();
Greet();
Greet();

// Úkol 2 - Doplň podmínky
Console.Write("Zadej číslo: ");
int number = int.Parse(Console.ReadLine() ?? "0");
if (number > 0)
{
    Console.WriteLine("Kladné číslo");
}
else if (number < 0)
{
    Console.WriteLine("Záporné číslo");
}
else
{
    Console.WriteLine("Nula");
}

// Úkol 3 - Oprav cyklus while
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}

// Úkol 4 - Funkce s parametrem
void PrintText(string text)
{
    Console.WriteLine(text);
}
PrintText("Programování je zábava");

// Úkol 5 - Oprava cyklu for
for (int i1 = 0; i1 < 5; i1++)
{
    Console.Write("*");
}