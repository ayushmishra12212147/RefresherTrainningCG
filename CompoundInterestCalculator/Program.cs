using System;

static class FinancialCalculator
{
    public static double CalculateCompoundInterest(double principal, double rate)
    {
        return CalculateCompoundInterest(principal, rate, 1, 1);
    }

    public static double CalculateCompoundInterest(double principal, double rate, int time)
    {
        return CalculateCompoundInterest(principal, rate, time, 1);
    }
    public static double CalculateCompoundInterest(double principal, double rate, int time, int compoundingFrequency)
    {
        return principal * Math.Pow(1 + rate / compoundingFrequency, compoundingFrequency * time);
    }
}

class Program
{
    static void Main()
    {
        double amount1 = FinancialCalculator.CalculateCompoundInterest(10000, 0.05, 10);

        double amount2 = FinancialCalculator.CalculateCompoundInterest(
            principal: 10000,
            rate: 0.05,
            time: 10,
            compoundingFrequency: 12);

        Console.WriteLine($"{amount1:F2}");
        Console.WriteLine($"{amount2:F2}");
    }
}