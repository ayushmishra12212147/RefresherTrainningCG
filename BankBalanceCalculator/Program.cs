using System;

class Program
{
    static void Main()
    {
        double openingBalance, deposits, withdrawals;

        Console.Write("Enter Opening Balance: ");
        if (!double.TryParse(Console.ReadLine(), out openingBalance) || openingBalance < 0)
        {
            Console.WriteLine("Invalid opening balance.");
            return;
        }

        Console.Write("Enter Total Deposits: ");
        if (!double.TryParse(Console.ReadLine(), out deposits) || deposits < 0)
        {
            Console.WriteLine("Invalid deposit amount.");
            return;
        }

        Console.Write("Enter Total Withdrawals: ");
        if (!double.TryParse(Console.ReadLine(), out withdrawals) || withdrawals < 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
            return;
        }

        double availableBalance = openingBalance + deposits;

        if (withdrawals > availableBalance)
        {
            Console.WriteLine("Withdrawals exceed available balance.");
            return;
        }

        double finalBalance = availableBalance - withdrawals;

        Console.WriteLine($"Opening Balance : {openingBalance:C2}");
        Console.WriteLine($"Deposits        : {deposits:C2}");
        Console.WriteLine($"Withdrawals     : {withdrawals:C2}");
        Console.WriteLine($"Final Balance   : {finalBalance:C2}");
    }
}