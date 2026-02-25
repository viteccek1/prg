namespace AcademicCompany.Manager;

public class Manager : AcademicCompany.Employees.Employee
{
    public Manager(string fullName, int salary) : base(fullName, salary)
    {
    }
    
    public void PrintSalary()
    {
        Console.WriteLine($"Manager má plat: {CalculateFinalSalary()}");
    }
}