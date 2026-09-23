FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("Bob", 50000, 5000);
PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Sue", 100, 20);


Console.WriteLine($"Full-time employee {fullTimeEmployee.Name}\n Salary: ${fullTimeEmployee.CalculateSalary():N2}\n");
Console.WriteLine($"Part-time employee {partTimeEmployee.Name}\n Salary: ${partTimeEmployee.CalculateSalary():N2}");