class Student 
{
    public int age;
    public string name;

    public Student(int age, string name)
    {
        this.name = name;
        this.age = age;
    }

    public void Greet()
    {
        Console.WriteLine("My name is: " + name + "And my age is: " + age);
    }
}