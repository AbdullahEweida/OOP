using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeClasses;

public abstract class Employee
{
    public string Name {get; set;}
    public decimal Salary {get; set;}
    public Employee(decimal Salary , string Name){ this.Salary = Salary; this.Name = Name;}
    public virtual void DisplayInfo(){}
}
public class SalariedEmployee : Employee
{
    public SalariedEmployee (decimal Salary, string Name) : base (Salary , Name){}
    public override void DisplayInfo()
    {
        Console.WriteLine($"Your Name : {Name}");
        Console.WriteLine($"fixed salary : {Salary}");
    }
}
public class HourlyEmployee : Employee
{
    public decimal Hour{get; set;}
    public decimal salary_hour {get; set;}
    public HourlyEmployee (decimal hour, string Name, decimal salary_hour) : base (hour, Name)
    {
        Hour = hour;
        this.salary_hour = salary_hour;
    }
    decimal CalculateSalary() => (Hour > 40) ? 1.5m * salary_hour * Hour
                                                                    : salary_hour * Hour;
    public override void DisplayInfo()
    {
        Console.WriteLine($"Your Name : {Name}");
        Console.WriteLine($"The number of hour : {Hour}\t The Salary : {CalculateSalary()}");
    }
}
public class CommissionEmployee : Employee
{
    public decimal percentage {get; set;}
    public decimal Salary_forOnePercentage {get; set;}
    public CommissionEmployee(decimal percentage,string Name, decimal Salary_forOnePercentage) : base (percentage, Name)
    {
        this.percentage = percentage;
        this.Salary_forOnePercentage = Salary_forOnePercentage;
    }
    protected virtual decimal CalculateSalary() => percentage * Salary_forOnePercentage;
    public override void DisplayInfo()
    {
        Console.WriteLine($"Your Name : {Name}");
        Console.WriteLine($"Percentage : {percentage}\t Salary for 1% : {Salary_forOnePercentage}");
        Console.WriteLine($"The final salary : {CalculateSalary()}");
    }
}
public class CommissionEmployeePlusSalaried : CommissionEmployee
{
    public decimal BaseSalary {get; set;}
    public CommissionEmployeePlusSalaried (decimal percentage, string Name, decimal Salary_forOnePercentage, decimal BaseSalary) : base (percentage, Name, Salary_forOnePercentage )
    {
        this.percentage = percentage;
        this.Salary_forOnePercentage = Salary_forOnePercentage;
        this.BaseSalary = BaseSalary;
    }
    private decimal salaryIncrement => BaseSalary * (10/100m);
    protected override decimal CalculateSalary() =>   (percentage * Salary_forOnePercentage) + BaseSalary + salaryIncrement;
    public override void DisplayInfo()
    {
        Console.WriteLine($"Your Name : {Name}");
        Console.WriteLine($"the base salary : {BaseSalary}\t salary increment : {salaryIncrement} ");
        Console.WriteLine($"Percentage : {percentage}\t Salary for 1% : {Salary_forOnePercentage}");
        Console.WriteLine($"The final salary : {CalculateSalary()}");

    }
}