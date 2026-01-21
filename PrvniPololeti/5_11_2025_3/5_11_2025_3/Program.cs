
// cele cisla 

int[] zacatkove = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Zadej číslo: ");
    zacatkove[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Původní pole: ");
for (int i = 0; i < 10; i++)
    Console.Write(zacatkove[i] + " ");
Console.WriteLine();

int[] obracene = new int[10];

for (int i = 0; i < 10; i++)
{
    obracene[i] = zacatkove[9 - i];
}

Console.WriteLine("Pole v opačném pořadí: ");
for (int i = 0; i < 10; i++)
    Console.Write(obracene[i] + " ");
Console.WriteLine();

// Jmena spoluzaku

string[] jmena = { "Kuba", "Matěj", "Patrik", "Vítek", "Mirek" };
        
Console.Write("Zadej jméno: ");
string hledaneJmeno = Console.ReadLine();
bool nalezeno = false;

for (int i = 0; i < jmena.Length; i++)
{
    if (jmena[i] == hledaneJmeno)
    {
        Console.WriteLine("ANO, jméno je v seznamu na indexu " + i);
        nalezeno = true;

    }

    if (nalezeno == false)
    {
        Console.WriteLine("NE, jméno není v seznamu");
    }
}


    
        
        
    