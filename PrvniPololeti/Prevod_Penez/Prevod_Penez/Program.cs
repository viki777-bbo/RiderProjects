/*
double ConvertToEuro(double czk)
{
    return czk / 25;
}
Console.WriteLine("Zadejte CZK:");
string input = Console.ReadLine();
double czk = double.Parse(input);

//todo tady bude pouzity prevod
double eur = ConvertToEuro(czk);
Console.WriteLine($"Hodnota v Eur: {eur}");
*/


/*
bool CheckPasswordSafety(string password)
{
    if (password.Length >= 8 && !password.Contains("heslo"))
    {
        return (password.Length >= 8 && !password.Contains("heslo"))

    }

    return false;
}
Console.WriteLine("Zadejte heslo:");
string heslo = Console.ReadLine();
if (CheckPasswordSafety(heslo))
{ 
     Console.WriteLine("Bezpečné");
}
else
{
    Console.WriteLine("Nebezpečné");
}
*/

void Frameword(string word)
{
    string stars = "";
    
    for (int i = 0; i < word.Length + 4; i++)
    {
        stars += "*";
    }
    
    Console.WriteLine(stars);
    Console.WriteLine("* " + word + " *");
    Console.WriteLine(stars);
}
Frameword("programovani"); ;
