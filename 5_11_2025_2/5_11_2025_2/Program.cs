int[] cisla = new int [5];
for (int i = 0; i < cisla.Length; i++)
{
    Boolean platnyVstup = false;
    while (platnyVstup == false)
    {
        Console.WriteLine("Zadej" + (i + 1) + ". číslo");
        string vstup = Console.ReadLine();
        int hodnota = int.Parse(vstup);

        if (hodnota <= 5 && hodnota >= 1)
            {
            platnyVstup = true;
            cisla[i] = hodnota;
            }
        else
        {
            Console.WriteLine("Špatně zadané číslo zkus to znovu");
        }
    }
}

int soucet = 0;

int minimum = cisla[0];
int maximum = cisla[5];
int pocetPetek = 0;
int pocetJednicek = 0;

for (int i = 0; i < cisla.Length; i++)
{
    soucet = soucet + cisla[i];
    if (cisla[i] > minimum) ;
    {
        minimum = cisla[i];
    }
    if (cisla[i] > maximum)
    {
        maximum = cisla[i];
    }

    if (cisla[i] == 5)
    {
        pocetPetek++;
    }

    if (cisla[i] == 1)
    {
        pocetJednicek++;
    }
}
double prumer = (double)soucet / cisla.Length;
Console.Write("Prumer je:" + prumer);
Console.Write("Soucet je:" + soucet);
Console.Write("Minimum je:" + minimum);
Console.Write("Maximum je:" + maximum);

for(int znamka = 1; znamka <=5; znamka++)
{
    int pocet = 0;

    for (int j = 0; j < cisla.Length; j++)
    {
        if (cisla[j] == znamka)
        {
            pocet++;
        }
} 
    Console.WriteLine("Pocet " + znamka + " je:" + pocet);
}

for (int i = 0; i < cisla.Length; i++)
{
    string slovne = "";
    switch (cisla[i])
    {
        case 1:
            slovne = "Vyborne";
            break;
        case 2:
            slovne = "Chvalitebne";
            break;
        case 3:
            slovne = "Dobre";
            break;
        case 4:
            slovne = "Dostatecne";
            break;
        case 5:
            slovne = "Nedostatecne";
            break;
       default:
            slovne = "x";
            break;
    }
    Console.WriteLine("Znamka"+ cisla[i] + "na" + i + ". pozici:" + slovne);
}


