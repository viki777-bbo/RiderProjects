class Student
{
    public string name;
    public int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class Program
{
    static void Main()
    {
        List<Student> studentList = new List<Student>();

        while (true)
        {
            Console.Write("Zadej jmeno studenta (nebo q pro konec): ");
            string name = Console.ReadLine();
            
            if (name == "q")
            {
                break;
            }
            
            Console.Write("Zadej vek studenta: ");
            int age = int.Parse(Console.ReadLine());
            studentList.Add(new Student(name, age));
        }
        Console.WriteLine("Pocet studentu: " + studentList.Count);

        foreach (var in studentList)
        {
            Console.WriteLine("Jmeno: " + s.name + ", Vek: " + s.age);
        }
    }
}