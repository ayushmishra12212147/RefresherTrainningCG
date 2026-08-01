using System;

class Program
{
    static void Main(string[] args)
    {
        double length, width, height;

        Console.Write("Enter Length: ");
        if (!double.TryParse(Console.ReadLine(), out length))
        {
            Console.WriteLine("Error: Invalid length entered.");
            return;
        }

        if (length <= 0)
        {
            Console.WriteLine("Error: Length must be greater than zero.");
            return;
        }

        Console.Write("Enter Width: ");
        if (!double.TryParse(Console.ReadLine(), out width))
        {
            Console.WriteLine("Error: Invalid width entered.");
            return;
        }

        if (width <= 0)
        {
            Console.WriteLine("Error: Width must be greater than zero.");
            return;
        }

        Console.Write("Enter Height: ");
        if (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Error: Invalid height entered.");
            return;
        }

        if (height <= 0)
        {
            Console.WriteLine("Error: Height must be greater than zero.");
            return;
        }

        double volume = length * width * height;

        Console.WriteLine($"Volume : {Math.Round(volume, 2)} cubic unit");
    }
}