using System;

class Program
{
    static int SumOfDigits(long n)
    {
        int sum = 0;

        while (n > 0)
        {
            sum += (int)(n % 10);
            n /= 10;
        }

        return sum;
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int count = 0;

        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i))
                continue;

            int s = SumOfDigits(i);
            int squareSum = SumOfDigits((long)i * i);

            if (squareSum == s * s)
                count++;
        }

        Console.WriteLine(count);
    }
}