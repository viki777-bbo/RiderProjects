Console.Clear();

Console.WriteLine("Zadej váhu v kg:");
string vstupVaha = Console.ReadLine();
float vaha = float.Parse(vstupVaha);

Console.WriteLine("Zadej výšku v cm:");
string vstupVyska = Console.ReadLine();
float vyskaCm = float.Parse(vstupVyska);

float vyskaM = vyskaCm / 100;
float bmi = vaha / (vyskaM * vyskaM);

Console.WriteLine("BMI: " + bmi);

if (bmi < 18.5)
{
    Console.WriteLine("Podváha");
}
else if (bmi < 25)
{
    Console.WriteLine("Normální váha");
}
else if (bmi < 30)
{
    Console.WriteLine("Nadváha");
}
else if (bmi < 35)
{
    Console.WriteLine("Obezita 1. stupně");
}
else if (bmi < 40)
{
    Console.WriteLine("Obezita 2. stupně");
}
else
{
    Console.WriteLine("Obezita 3. stupně");
}

