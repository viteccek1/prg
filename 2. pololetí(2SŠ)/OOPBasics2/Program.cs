/*
Console.Clear();

Book book = new Book("Karel Hynek Mácha", 1948, 187, "Cikáni");
book.PrintInfo();
*/

/*
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
*/


Console.Clear();
List<Student> StudentList = new List<Student>();


while (true)
{
    int age;
    string name;
    Console.WriteLine("Zadejte konec pro ukonceni");
    Console.Write("Zadejte jméno studenta:");
     name = Console.ReadLine();
    if (name == "konec".ToUpper() || string.IsNullOrWhiteSpace(name))
    {
        break;
    }

    Console.Write("Zadejte věk studenta:");
    age = int.Parse(Console.ReadLine());
    
    Student student = new Student(age, name);
    StudentList.Add(student);
}

foreach (var student in StudentList)
{
    student.Greet();
}

