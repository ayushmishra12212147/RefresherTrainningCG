using System;
namespace TopBrains
{
    public class Conversion
    {
        static void Main(string[] args)
        {
            int input=Convert.ToInt32(Console.ReadLine());
            double result=input*30.48;
            Console.WriteLine($"{result:.2f}");
            Console.WriteLine();
        }
    }
}