using System;
namespace TopBrains{
class Q22Swapping
{
    public static void Q22Main()
    {
        int a=20;
        int b=30;

        System.Console.WriteLine($"Before Swap {a} and {b}");
        SwapWithRef(ref a,ref b);
        System.Console.WriteLine($"After Swap With Ref {a} and {b}");
        SwapWithOut(a,b,out int x,out int y);
        System.Console.WriteLine($"After again Swapping using Out {a} and {b}");

    }
    public static void SwapWithRef(ref int a, ref int b)
    {
        a=a+b;
        b=a-b;
        a=a-b;
    }
    public static void SwapWithOut(int a, int b,out int x,out int y)
        {
            x=b;
            y=a;

           
            
            
        }
}}
