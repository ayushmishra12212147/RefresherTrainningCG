using System;
using System.Collections.Generic;

class Transaction
{
    public string Id;
    public List<Transaction> Next = new List<Transaction>();
    public Transaction(string id)
    {
        Id = id;
    }
}

static class RiskCalculator
{
    public static int CalculateRiskScore(Transaction transaction, ref int depth)
    {
        if (depth > 1000)
        {
            Console.WriteLine("Maximum recursion depth reached.");
            return -1;
        }
        depth++;
        int score = 1;
        foreach (Transaction child in transaction.Next)
        {
            score += CalculateRiskScore(child, ref depth);
        }
        depth--;
        return score;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter ID: ");
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }
        Transaction t1 = new Transaction(input);
        Transaction t2 = new Transaction("TX002");
        Transaction t3 = new Transaction("TX003");
        t1.Next.Add(t2);
        t2.Next.Add(t3);
        int depth = 0;
        int risk = RiskCalculator.CalculateRiskScore(t1, ref depth);
        Console.WriteLine($" {risk}");
    }
}