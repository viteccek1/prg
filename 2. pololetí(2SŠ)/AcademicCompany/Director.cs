namespace AcademicCompany.Director;

public class Director : AcademicCompany.Manager.Manager
{
    public int StockCount;
    
    public Director(string fullName, int salary, int stockCount) : base(fullName, salary)
    {
        StockCount = stockCount;
    }

    protected override double CalculateFinalSalary()
    {
        return base.CalculateFinalSalary() + (StockCount * 100);
    }


    public void PrintDirectorInfo()
    {
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Výsledný plat (Bonus + Akcie): {CalculateFinalSalary()} Kč");
    }
}