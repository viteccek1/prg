Console.Clear();
Student student = new Student(17, "Vitek");
Console.WriteLine("Student name: " + student.name);
student.Greet();
ChangeStudent(student);
student.Greet();
void ChangeStudent(Student s)
{
    s.name = "Nothing";
}

