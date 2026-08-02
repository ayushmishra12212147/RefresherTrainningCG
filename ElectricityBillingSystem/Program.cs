using System;

interface IBillCalculator
{
    double CalculateBill(double units, double rate, double fixedCharge);
}

class ResidentialCustomer : IBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharge)
    {
        return (units * rate) + fixedCharge;
    }
}

class CommercialCustomer : IBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharge)
    {
        return (units * rate * 1.20) + fixedCharge;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Customer Type (Residential/Commercial): ");
        string type = Console.ReadLine();

        if (!double.TryParse(ReadValue("Units Consumed"), out double units) || units < 0)
        {
            Console.WriteLine("Invalid Units.");
            return;
        }

        if (!double.TryParse(ReadValue("Rate Per Unit"), out double rate) || rate < 0)
        {
            Console.WriteLine("Invalid Rate.");
            return;
        }

        if (!double.TryParse(ReadValue("Fixed Charges"), out double fixedCharge) || fixedCharge < 0)
        {
            Console.WriteLine("Invalid Fixed Charges.");
            return;
        }

        IBillCalculator calculator;

        if (type.Equals("Residential", StringComparison.OrdinalIgnoreCase))
        {
            calculator = new ResidentialCustomer();
        }
        else if (type.Equals("Commercial", StringComparison.OrdinalIgnoreCase))
        {
            calculator = new CommercialCustomer();
        }
        else
        {
            Console.WriteLine("Invalid Customer Type.");
            return;
        }

        double bill = calculator.CalculateBill(units, rate, fixedCharge);
        Console.WriteLine($"Customer Type : {type}");
        Console.WriteLine($"Units         : {units}");
        Console.WriteLine($"Rate          : {rate}");
        Console.WriteLine($"Fixed Charge  : {fixedCharge}");
        Console.WriteLine($"Total Bill    : {Math.Round(bill, 2)}");
    }
    static string ReadValue(string message)
    {
        Console.Write($"{message}: ");
        return Console.ReadLine();
    }
}