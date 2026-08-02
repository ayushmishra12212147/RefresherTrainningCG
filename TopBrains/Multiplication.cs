using System;
namespace TopBrains
{
    public class Q23Multiplication
    {
        public static void Q23Main()
        {
            System.Console.WriteLine("Enter Value of N");
            int n=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Upto value");
            int upto=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= upto; i++)
            {
                System.Console.Write(i*n);
            }

            
        }
    }
}