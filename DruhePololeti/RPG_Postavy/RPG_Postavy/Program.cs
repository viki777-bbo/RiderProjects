class Program
{
    static List<Character> characters = new();

    static void Main()
    {
        characters.Add(new Warrior("Ervon", 10, "Zlata Motyka"));
        characters.Add(new Mage("Osmund", 20, 100));

        foreach (Character character in characters)
        {
            character.Attack();
        }
    }
}
class Character
{
    public string Name { get; set; }
    public int Level { get; set; }

    public Character(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} utoci!");
    }
}

class Warrior : Character
{
    public string WeaponName { get; set; }

    public Warrior(string name, int level, string weaponName)
        : base(name, level)
    {
        WeaponName = weaponName;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} utoci pomoci {WeaponName}!");
    }
}

class Mage : Character
{
    public int ManaPoints { get; set; }

    public Mage(string name, int level, int manaPoints)
        : base(name, level)
    {
        ManaPoints = manaPoints;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} posila curse spell a zbyva mu {ManaPoints} many");
    }
}