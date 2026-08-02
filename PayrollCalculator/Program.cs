using System;

class Employee
{
    public string Name { get; set; }
    public double HoursWorked { get; set; }
    public double HourlyRate { get; set; }
}

class PayrollCalculator
{
    public double CalculateRegularPay(double hours, double rate)
    {
        return Math.Min(hours, 40) * rate;
    }

    public double CalculateOvertimePay(double hours, double rate)
    {
        if (hours > 40)
            return (hours - 40) * rate * 1.5;

        return 0;
    }

    public double CalculateGrossSalary(Employee emp)
    {
        return CalculateRegularPay(emp.HoursWorked, emp.HourlyRate)
             + CalculateOvertimePay(emp.HoursWorked, emp.HourlyRate);
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Hours Worked: ");
        if (!double.TryParse(Console.ReadLine(), out double hours) || hours < 0 || hours > 300)
        {
            Console.WriteLine("Invalid Hours Worked.");
            return;
        }

        Console.Write("Enter Hourly Rate: ");
        if (!double.TryParse(Console.ReadLine(), out double rate) || rate <= 0)
        {
            Console.WriteLine("Invalid Hourly Rate.");
            return;
        }

        emp.HoursWorked = hours;
        emp.HourlyRate = rate;

        PayrollCalculator payroll = new PayrollCalculator();
        double regularPay = payroll.CalculateRegularPay(hours, rate);
        double overtimePay = payroll.CalculateOvertimePay(hours, rate);
        double grossSalary = payroll.CalculateGrossSalary(emp);
        Console.WriteLine($"Employee      : {emp.Name}");
        Console.WriteLine($"Regular Pay   : {Math.Round(regularPay, 2)}");
        Console.WriteLine($"Overtime Pay  : {Math.Round(overtimePay, 2)}");
        Console.WriteLine($"Gross Salary  : {Math.Round(grossSalary, 2)}");
    }
}