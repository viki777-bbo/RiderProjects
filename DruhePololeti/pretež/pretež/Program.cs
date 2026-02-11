/*
Person person1 = new Person("Adam");
Console.WriteLine(person1.GetInfo());
Person person2 = new Person("Petr", 17);
Console.WriteLine(person2.GetInfo());
public class Person
{
    public string Name;
    public int Age;

    public Person(string name)
    {
        Name = name;
        Age = 0;
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string GetInfo()
    {
        return $"{Name} is {Age} years old";
    }
}
*/



/*

        string name = "Ram";
        double price = 100000;

        Product product = new Product();
        product.Name = name;
        product.Price = price;

        Console.WriteLine($"{product.Name}: ${product.Price}");

public class Product
{
    private string _name;
    private double _price;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value > 0)
            {
                _price = value;
            }
        }
    }
}
*/



//Upravte existující třídu Person, aby používala C# auto-properties.


Person person = new Person("David", 23, "david.marek@academicschool.cz");

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    
    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
    
    public string GetName() { return Name; }
    public void SetName(string value) { Name = value; }
    
    public int GetAge() { return Age; }
    public void SetAge(int value) { Age = value; }
    
    public string GetEmail() { return Email; }
    public void SetEmail(string value) { Email = value; }
}