using System;

class Employee
{
    // Constants
    private const int FullTimeWagePerHour = 20;
    private const int PartTimeWagePerHour = 15;
    private const int FullTimeHours = 8;
    private const int PartTimeHours = 4;
    private const int WorkingDaysPerMonth = 20;
    private const int MaxWorkingHours = 100;
    private const int MaxWorkingDays = 20;

    // Class variables
    private int totalHoursWorked;
    private int totalWorkingDays;
    private readonly int dailyWage;

    // Constructor
    public Employee(int employeeType)
    {
        if (employeeType == 1)
        {
            // Full-time employee
            dailyWage = FullTimeWagePerHour * FullTimeHours;
        }
        else if (employeeType == 2)
        {
            // Part-time employee
            dailyWage = PartTimeWagePerHour * PartTimeHours;
        }
        else
        {
            Console.WriteLine("Invalid employee type. Please select either 1 or 2.");
        }
        Console.WriteLine($"Daily employee wages is {dailyWage}");
    }

    // Method to compute monthly wage
    public int ComputeMonthlyWage()
    {
        totalHoursWorked = Math.Min(MaxWorkingHours, FullTimeHours * WorkingDaysPerMonth);
        totalWorkingDays = Math.Min(MaxWorkingDays, WorkingDaysPerMonth);

        return dailyWage * totalWorkingDays;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter employee type:");
        Console.WriteLine("1. Full-time");
        Console.WriteLine("2. Part-time");
        Console.Write("Your choice: ");
        int employeeType = int.Parse(Console.ReadLine());

            Employee employee = new Employee(employeeType);
            int monthlyWage = employee.ComputeMonthlyWage();
            Console.WriteLine($"Monthly Employee Wage: ${monthlyWage}");
    }
}
