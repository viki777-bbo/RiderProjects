class Enemy
{
    private static int _nextId = 1;                   
    public static double DifficultyMultiplier = 1.0;   


    public int Id { get; private set; }         
    public string Name { get; set; }          
    public double BaseHealth { get; set; }       
    
    public double CurrentHealth
    {
        get { return BaseHealth * DifficultyMultiplier; }
    }
    public Enemy(string name, double baseHealth)
    {
        Name = name;
        BaseHealth = baseHealth;
        Id = _nextId;      
        _nextId++;         
    }
    public static void SetDifficulty(double multiplier)
    {
        DifficultyMultiplier = multiplier;
    }
}