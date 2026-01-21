Console.Write("Enter age");
string ageString = Console.ReadLine();
int age = int.Parse(ageString);
if (age > 150 || age < 0)
{
    Console.WriteLine("Nepovolena hodnota");
}
else if (age < 18)
{
    Console.WriteLine("Jsi nezletilý");
}
else if (age > 65)
{
    Console.WriteLine("Jsi senior");
}
else
{
    Console.WriteLine("Jsi dospely");
}
