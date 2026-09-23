public class Employee
{

    public string Name { get; set; }
    public decimal BaseSalary { get; set; }


    public Employee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    public virtual decimal CalculateSalary()
    {
        return BaseSalary;
    }
}

public class FullTimeEmployee : Employee
{
    public decimal Bonus { get; set; }
    public FullTimeEmployee(string name, decimal baseSalary, decimal bonus)
        : base(name, baseSalary)
    {
        Bonus = bonus;
    }
    public override decimal CalculateSalary()
    {
        return BaseSalary + Bonus;
    }
}
public class PartTimeEmployee : Employee
{
    public int HoursWorked { get; set; }
    public decimal HourlyRate { get; set; }
    public PartTimeEmployee(string name, int hoursWorked, decimal hourlyRate)
        : base(name, 0)
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }
    public override decimal CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }
}
