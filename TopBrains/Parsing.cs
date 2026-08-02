using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;
namespace TopBrains
{
    public class Parsing
    {
        static void Main(string[] args)
        {
            string?[] stringarray=new string[5];
            Console.WriteLine("Enter 5 integer Values ");
            for (int i = 0; i < 5; i++)
            {
                stringarray[i]=Console.ReadLine();
            }
            //parsing now 
            int sum=0;
            foreach(var v in stringarray)
            {
                int.TryParse(v,out int k);
                sum+=k;
                
            }
            Console.WriteLine(sum);
        }
    }
}