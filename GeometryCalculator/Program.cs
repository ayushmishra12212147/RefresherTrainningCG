using System;

static class GeometryCalculator
{
    public static double CalculateArea(double radius, int decimals = 2)
    {
        return Math.Round(Math.PI * radius * radius, decimals);
    }

    public static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    public static double CalculateArea(double triangleBase, double height, bool triangle)
    {
        return 0.5 * triangleBase * height;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"{GeometryCalculator.CalculateArea(5)}");
        Console.WriteLine($"{GeometryCalculator.CalculateArea(4,6)}");
        Console.WriteLine($"{GeometryCalculator.CalculateArea(3,7,true)}");
        Console.WriteLine($"{GeometryCalculator.CalculateArea(radius:5,decimals:4)}");
    }
}