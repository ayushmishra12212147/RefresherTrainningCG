using System;

interface IInvestmentCalculator
{
    double CalculateReturn(double principal, double rate, int years);
}

class SimpleInvestment : IInvestmentCalculator
{
    public double CalculateReturn(double principal, double rate, int years)
    {
        return principal + (principal * rate * years / 100);
    }
}

class CompoundInvestment : IInvestmentCalculator
{
    public double CalculateReturn(double principal, double rate, int years)
    {
        return principal * Math.Pow(1 + rate / 100, years);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Investment Type (Simple/Compound): ");
        string type = Console.ReadLine();

        Console.Write("Principal Amount: ");
        if (!double.TryParse(Console.ReadLine(), out double principal) || principal <= 0)
        {
            Console.WriteLine("Invalid Principal Amount.");
            return;
        }

        Console.Write("Annual Rate (%): ");
        if (!double.TryParse(Console.ReadLine(), out double rate) || rate < 0 || rate > 100)
        {
            Console.WriteLine("Invalid Interest Rate.");
            return;
        }

        Console.Write("Duration (Years): ");
        if (!int.TryParse(Console.ReadLine(), out int years) || years <= 0)
        {
            Console.WriteLine("Invalid Duration.");
            return;
        }

        IInvestmentCalculator calculator;

        if (type.Equals("Simple", StringComparison.OrdinalIgnoreCase))
        {
            calculator = new SimpleInvestment();
        }
        else if (type.Equals("Compound", StringComparison.OrdinalIgnoreCase))
        {
            calculator = new CompoundInvestment();
        }
        else
        {
            Console.WriteLine("Invalid Investment Type.");
            return;
        }

        double finalAmount = calculator.CalculateReturn(principal, rate, years);
        Console.WriteLine($"Investment Type : {type}");
        Console.WriteLine($"Principal       : {principal:C2}");
        Console.WriteLine($"Rate            : {rate}%");
        Console.WriteLine($"Duration        : {years} Years");
        Console.WriteLine($"Final Value     : {Math.Round(finalAmount, 2):C2}");
    }
}