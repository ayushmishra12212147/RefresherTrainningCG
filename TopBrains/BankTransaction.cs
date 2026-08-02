using System;
using System.Runtime;
namespace TopBrains
{
    class BankTransaction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter initial Balance and transactions seperated by space - +for deposit and -for dithdraw 10 Values");
            int initialBalance=Convert.ToInt32(Console.ReadLine());
            int[] trans=new int[10];
            for (int i = 0; i < 10; i++)
            {
                trans[i]=Convert.ToInt32(Console.ReadLine());
                
            }
            foreach(int tra in trans)
            {
                if (tra > 0)
                {
                    initialBalance+=tra;
                }
                else
                {
                    if (tra > initialBalance)
                    {
                        Console.WriteLine("Not Enough Balance");
                    }
                    else
                    {
                        initialBalance-=tra;
                    }
                }
            }
            Console.WriteLine(initialBalance);
        }
    }
}