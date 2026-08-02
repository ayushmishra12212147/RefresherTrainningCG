using System;
namespace TopBrains
{
    public class Strings
    {
        static void Main(string[] args)
        {
            double result=0;
            Console.WriteLine("Enter the input in format.");
            Console.WriteLine("For Circle:- C R");
            Console.WriteLine("For Rectangle: R W H");
            Console.WriteLine("For Triangle: T B H");
            
            string? input = Console.ReadLine();
            switch (input[0])
            {
                case 'C':
                    {
                        result = (22 * Convert.ToInt32(input[2]) * Convert.ToInt32(input[2])) / 7;
                        break;
                    }
                case 'R':
                    {
                        int w = Convert.ToInt32(input[2]);
                        int h = Convert.ToInt32(input[4]);
                        result = w * h;
                        break;
                    }
                case 'T':
                    {
                        int b = Convert.ToInt32(input[2]);
                        int h = Convert.ToInt32(input[4]);
                        result = 0.5 * b * h;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Input");
                        break;
                    }
            }
            Console.WriteLine(result);
        }
    }

}