using System;
using System.Collections.Generic;

static class OrderProcessor
{
    static bool TryParseISBN(string isbn, out string cleanedISBN)
    {
        cleanedISBN = isbn.Replace("-", "").Trim();

        if (cleanedISBN.Length == 13)
            return true;

        cleanedISBN = "";
        return false;
    }

    public static bool TryProcessOrder(out List<string> validISBNs, params string[] isbns)
    {
        validISBNs = new List<string>();
        bool found = false;

        foreach (string isbn in isbns)
        {
            if (TryParseISBN(isbn, out string clean))
            {
                validISBNs.Add(clean);
                found = true;
            }
        }

        return found;
    }
}

class Program
{
    static void Main()
    {
        bool result = OrderProcessor.TryProcessOrder(
            out List<string> books,
            "978-3-16-148410-0",
            "1234567890123",
            "invalid-isbn",
            "978-1-4028-9462-6"
        );

        Console.WriteLine($"{result}");

        Console.WriteLine("\nISBN List:");

        foreach (string isbn in books)
        {
            Console.WriteLine(isbn);
        }
    }
}