string filename = "input.txt";
if (!File.Exists(filename))
{
    Console.WriteLine($"File {filename} does not exist.");
    return;
}

string[] lines = File.ReadAllLines(filename);

int safeCount = 0;

foreach (string line in lines)
{
    // Rozdělím řádek na čísla
    string[] numStrings = line.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    
    // Převedu na List<int>
    var levels = new List<int>();
    foreach (string numStr in numStrings)
    {
        levels.Add(int.Parse(numStr));
    }
    
    // Zkontroluju, jestli je report bezpečný
    bool isSafe = IsReportSafe(levels);
    
    if (isSafe)
    {
        safeCount++;
        Console.WriteLine($"SAFE: {line}");
    }
    else
    {
        Console.WriteLine($"UNSAFE: {line}");
    }
}

Console.WriteLine($"\nTotal safe reports: {safeCount}");

// Funkce která zkontroluje, jestli je report bezpečný
bool IsReportSafe(List<int> levels)
{
    if (levels.Count < 2)
        return true;
    
    // Zjistím směr (roste nebo klesá) z prvních dvou čísel
    bool shouldIncrease = levels[1] > levels[0];
    
    // Projdu všechny sousední dvojice
    for (int i = 0; i < levels.Count - 1; i++)
    {
        int current = levels[i];
        int next = levels[i + 1];
        int diff = next - current;
        
        // Kontrola 1: Směr se musí shodovat
        if (shouldIncrease && diff <= 0)
            return false; // Mělo růst, ale neroste
        
        if (!shouldIncrease && diff >= 0)
            return false; // Mělo klesat, ale neklesá
        
        // Kontrola 2: Rozdíl musí být 1, 2 nebo 3
        int absDiff = Math.Abs(diff);
        if (absDiff < 1 || absDiff > 3)
            return false;
    }
    
    return true;
}