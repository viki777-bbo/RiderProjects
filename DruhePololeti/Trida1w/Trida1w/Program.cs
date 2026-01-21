class Wall
{
    public float height;
    public float width;
    public string material;

    public Wall(float height, float width, string material)
    {
        this.height = height;
        this.width = width;
        this.material = material;
    }
    
    public float GetSurface()
    {
        return width * height;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine("Zeď: výška = " + height + "m, šířka = " + width + "m, materiál = " + material + ", plocha = " + GetSurface() + "m²");
    }
}