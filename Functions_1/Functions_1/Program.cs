void Greet(string name)
{
    Console.WriteLine($"Howdy {name}");
}

int AddTwoNumbers(int a, int b)
{
    return a + b;
}

void MakeDouble(int x)
{
    x = x * 2;
}

Greet("Viktor");

int z = AddTwoNumbers(3,4);
Console.WriteLine(z);

MakeDouble(z);

Console.WriteLine(z);

if (z > 10)
{
    int a = 10;
}