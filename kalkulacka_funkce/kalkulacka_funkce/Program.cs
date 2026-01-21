using System;

class Program
{
    static void Main()
    {
        Console.Write("First number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Operator (+ - * /): ");
        string op = Console.ReadLine();

        Console.Write("Second number: ");
        double b = double.Parse(Console.ReadLine());

        double result = op switch
        {
            "+" => Add(a, b),
            "-" => Sub(a, b),
            "*" => Mul(a, b),
            "/" => Div(a, b),
            _ => 0
        };

        Console.WriteLine("Result: " + result);
    }
    static double Add(double x, double y) => x + y;
    static double Sub(double x, double y) => x - y;
    static double Mul(double x, double y) => x * y;
    static double Div(double x, double y) => x / y;
}