string filename = "input.txt";
if (!File.Exists(filename))
{
    Console.WriteLine($"File {filename} does not exist.");
    return;
}

string[] lines = File.ReadAllLines(filename);

var numsA = new List<int>();
var numsB = new List<int>();

foreach (string line in lines)
{
    string[] numStrings = line.Split(' ', options: StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    if (numStrings.Length != 2)
    {
        Console.WriteLine("File format is not valid.");
        return;
    }

    numsA.Add(int.Parse(numStrings[0]));
    numsB.Add(int.Parse(numStrings[1]));
}

int similarityScore = 0;

/* Pro každé číslo z levého seznamu */
foreach (int leftNum in numsA)
{
    /* Spočítej, kolikrát se objevuje v pravém seznamu */
    int count = 0;
    foreach (int rightNum in numsB)
    {
        if (leftNum == rightNum)
        {
            count++;
        }
    }
    
    /* Přičti k celkovému skóre: číslo × počet výskytů */
    similarityScore += leftNum * count;
}

Console.WriteLine($"Similarity score: {similarityScore}");
