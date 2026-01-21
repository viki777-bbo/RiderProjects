Console.Write("Zadej znamku (1-5): ");
int znamka = int.Parse(Console.ReadLine());
string vysledek;

if (znamka == 1)
{
    vysledek = "Vyborne";
}
else if (znamka == 2)
{
    vysledek = "Chvalitebne";
}
else if (znamka == 3)
{
    vysledek = "Dobre";
}
else if (znamka == 4)
{
    vysledek = "Dostatecne";
}
else if (znamka == 5)
{
    vysledek = "Nedostatecne";
}
else
{
    vysledek = "Neplatná známka";
}
Console.WriteLine("Zadej známku (1-5): " + vysledek);