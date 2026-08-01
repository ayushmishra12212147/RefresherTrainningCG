using System;

public class Program
{
    static void Main(string[] args)
    {
        double weight, height;

        Console.Write("Enter Weight kg: ");
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Error: Invalid weight entered.");
            return;
        }

        if (weight <= 0)
        {
            Console.WriteLine("Error: Weight must be greater than zero.");
            return;
        }

        Console.Write("Enter Height (meters): ");
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

        double bmi = weight / (height * height);
        bmi = Math.Round(bmi, 2);

        string category;

        if (bmi < 18.5)
            category = "Underweight";
        else if (bmi < 25)
            category = "Normal Weight";
        else if (bmi < 30)
            category = "Overweight";
        else
            category = "Obese";

        Console.WriteLine($"BMI      : {bmi}");
        Console.WriteLine($"Category : {category}");
    }
}