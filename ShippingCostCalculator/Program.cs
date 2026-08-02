using System;

interface IShippingCalculator
{
    double CalculateCost(double weight, double distance);
}

class StandardPackage : IShippingCalculator
{
    public double CalculateCost(double weight, double distance)
    {
        return (weight * 5) + (distance * 0.5);
    }
}

class ExpressPackage : IShippingCalculator
{
    public double CalculateCost(double weight, double distance)
    {
        return (weight * 8) + (distance * 1.0);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Package Type (Standard/Express): ");
        string type = Console.ReadLine();

        Console.Write("Enter Weight (kg): ");
        if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0 || weight > 1000)
        {
            Console.WriteLine("Invalid Weight.");
            return;
        }

        Console.Write("Enter Distance (km): ");
        if (!double.TryParse(Console.ReadLine(), out double distance) || distance <= 0 || distance > 10000)
        {
            Console.WriteLine("Invalid Distance.");
            return;
        }

        IShippingCalculator calculator;

        if (type.Equals("Standard", StringComparison.OrdinalIgnoreCase))
            calculator = new StandardPackage();
        else if (type.Equals("Express", StringComparison.OrdinalIgnoreCase))
            calculator = new ExpressPackage();
        else
        {
            Console.WriteLine("Invalid Package Type.");
            return;
        }

        double cost = calculator.CalculateCost(weight, distance);
        Console.WriteLine($"Package Type : {type}");
        Console.WriteLine($"Weight       : {weight} kg");
        Console.WriteLine($"Distance     : {distance} km");
        Console.WriteLine($"Shipping Cost: {Math.Round(cost, 2)}");
    }
}