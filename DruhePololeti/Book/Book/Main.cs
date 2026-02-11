class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Babička", "Božena Němcová", 1855, 416);
        Book book2 = new Book("Osudy dobrého vojáka Švejka", "Jaroslav Hašek", 1921, 752);
        List<string> bookList = new List<string>();
        
        bookList.Add("Farma zvirat");
        bookList.Add("1984");
        
    bookList.RemoveAt(1);    
    
    Console.WriteLine(bookList.Count);

    foreach (string book in bookList)
    {
        Console.WriteLine(book);
    }
    