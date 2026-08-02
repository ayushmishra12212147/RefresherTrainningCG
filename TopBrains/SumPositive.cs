using System;
using System.IO.Compression;
namespace TopBrains
{
    public class SumPositive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 values in Array");
            int[] numsArray=new int[10];

            for(int i = 0; i < 10; i++)
            {
                numsArray[i]=Convert.ToInt32(Console.ReadLine());
            }
            int sum=0;
            foreach(var v in numsArray)
            {
                if (v == 0)
                {
                    break;
                }else if (v < 0)
                {
                    continue;
                }
                sum+=v; 
            }
            Console.WriteLine(sum);
        }
    }
}