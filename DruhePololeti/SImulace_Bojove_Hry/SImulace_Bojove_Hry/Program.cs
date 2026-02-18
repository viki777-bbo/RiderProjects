using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Goblin", 50),
            new Enemy("Orc", 100),
            new Enemy("Troll", 150)
        };
        Console.WriteLine("=== NORMALNI OBTIZNOST ===");
        foreach (Enemy enemy in enemies)
        {
            Console.WriteLine($"ID: {enemy.Id}, Jméno: {enemy.Name}, Životy: {enemy.CurrentHealth}");
        }
        Enemy.SetDifficulty(2.5);
        Console.WriteLine("=== TEZKA OBTIZNOST (2.5) ===");
        foreach (Enemy enemy in enemies)
        {
            Console.WriteLine($"ID: {enemy.Id}, Jméno: {enemy.Name}, Životy: {enemy.CurrentHealth}");
        }
    }
}