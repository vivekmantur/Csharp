// Step 1: Define a base abstract class for common employee properties
public abstract class Employee
{
    public string Name { get; set; }

    // Base class does not assume all employees have salaries
    public abstract decimal GetCompensation();
}

// Step 2: Implement PermanentEmployee which calculates salary
public class PermanentEmployee : Employee
{
    public override decimal GetCompensation()
    {
        return 3000;  // Permanent employee salary
    }
}

// Step 3: Implement Intern which calculates a stipend instead of salary
public class Intern : Employee
{
    public override decimal GetCompensation()
    {
        return 1000;  // Intern stipend
    }
}
public class Program
{
    public static void Main()
    {
        // PermanentEmployee works as expected
        Employee emp = new PermanentEmployee();
        Console.WriteLine($"Permanent Employee Compensation: {emp.GetCompensation()}");  // Output: 3000

        // Intern now works correctly without causing exceptions
        Employee intern = new Intern();
        Console.WriteLine($"Intern Compensation: {intern.GetCompensation()}");  // Output: 1000
    }
}
