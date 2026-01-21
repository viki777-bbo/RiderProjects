Console.Write("Zadejte jméno a příjmení: ");
string vstup = Console.ReadLine();
        
vstup = vstup.Trim();
        
string mala = vstup.ToLower();
        
int poziceMezery = mala.IndexOf(" ");
Console.WriteLine("Pozice mezery: " + poziceMezery);
        
string[] casti = mala.Split(" ");
        
string prijmeni = casti[1][0].ToString().ToUpper() + casti[1].Substring(1);
        
Console.WriteLine("Příjmení: " + prijmeni);
        
string vysledek = casti[0][0].ToString().ToUpper() + "." + prijmeni;
        
Console.WriteLine(vysledek); 
