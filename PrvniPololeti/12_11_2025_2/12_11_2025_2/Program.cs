string datum = "2025-11-11T16:00";
string rok = datum.Substring(0,4);
string cas = datum.Substring(11);
string den = datum.Substring(5,5);

// Console.WriteLine($"Rok: {rok}, Cas: {cas}, Den: {den}");

string text = "Cena: 100Kc, Doprava: 50 Kc";
string opaveno = text.Replace("Kc", "CZK");
Console.WriteLine(opaveno);

string csvRadek = "Pavel;Novak;30;Praha";
string[] casti = csvRadek.Split(";");

Console.WriteLine($"Jmeno: {casti[0]}, Prijmeni: {casti[1]}, Vek:  {casti[2]}, Mesto: {casti[3]}");

string veta = "Dnes je krasny den";
string[] slova = veta.Split(" ");
Console.WriteLine(slova.Length);

