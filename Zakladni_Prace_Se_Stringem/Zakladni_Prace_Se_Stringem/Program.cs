Console.Write("Zadej sve jmeno a prijmeni: ");
string vstup = Console.ReadLine();
        
string ocistenyVstup = vstup.Trim();
        
Console.WriteLine("Celkovy pocet znaku: " + ocistenyVstup.Length);
Console.WriteLine("Velka pismena: " + ocistenyVstup.ToUpper());
Console.WriteLine("Obsahuje 'Jan': " + ocistenyVstup.Contains("Jan"));
        
if (ocistenyVstup.Length > 0)
{
    Console.WriteLine("První písmeno: " + ocistenyVstup[0]);
    Console.WriteLine("Poslední písmeno: " + ocistenyVstup[ocistenyVstup.Length - 1]);
}



