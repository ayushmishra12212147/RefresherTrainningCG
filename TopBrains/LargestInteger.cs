using System;
using System.IO.Compression;
namespace TopBrains
{
    public class LargestInteger
    {
        public static void LargestIntegerMain()
        {
            Console.WriteLine("Enter 1st Numnber");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            int num3=Convert.ToInt32(Console.ReadLine());
            int lar;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    lar=num1;
                }
                else
                {
                    lar=num3;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    lar=num2;
                }
                else
                {
                    lar=num3;
                }
            }

            Console.WriteLine($"{lar}");

        }
    }
}