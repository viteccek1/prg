Console.Clear();

Book book = new Book("Karel Hynek Mácha", 1948, 187, "Cikáni");
book.PrintInfo();

class Book
{
    public string Autor;
    public int ReleaseYear;
    public int PageCount;
    public string Name;

    public Book(string Autor, int ReleaseYear, int PageCount, string Name)
    {
        this.Autor = Autor;
        this.ReleaseYear = ReleaseYear;
        this.PageCount = PageCount;
        this.Name = Name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ReleaseYear: {ReleaseYear}");
        Console.WriteLine($"PageCount: {PageCount}");
        Console.WriteLine($"Name: {Name}");
    }
}
