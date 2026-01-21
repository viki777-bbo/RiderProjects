// Deklarace pole
int[] mojeCisla;

// Inicializace
mojeCisla = new int[5];

// Kombinace
int[] znamky = new int[5];

// Přístup k prvkům
znamky[0] = 1; // první pozice je hodnota 1
znamky[1] = 3;
znamky[2] = 2; // Poslední pozice v array znamek

int prvniZnamka = znamky[0];
Console.WriteLine(prvniZnamka);

Console.WriteLine(znamky[3]);

string[] dnyVTydnu = new string[7];

dnyVTydnu[0] = "Pondělí";
dnyVTydnu[1] = "Úterý";

string[] dnyVTydnuJinak = {"Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Neděle" };

Console.WriteLine(dnyVTydnuJinak[1] + ", " + dnyVTydnuJinak[5]);

int velikost = dnyVTydnuJinak.Length;

Console.WriteLine("Velikost pole Dny v Tydnu:" + velikost);

for(int i = 0; i < dnyVTydnuJinak.Length; i++)
{
    Console.WriteLine(dnyVTydnuJinak[i]);
}