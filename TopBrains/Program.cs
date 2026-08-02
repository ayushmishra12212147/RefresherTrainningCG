using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static bool IsVowel(char ch)
    {
        ch = char.ToLower(ch);
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }

    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        HashSet<char> secondChars = new HashSet<char>();
        foreach (char ch in second)
        {
            secondChars.Add(char.ToLower(ch));
        }

        StringBuilder temp = new StringBuilder();

        foreach (char ch in first)
        {
            char lower = char.ToLower(ch);

            if (!IsVowel(ch) && secondChars.Contains(lower))
                continue;

            temp.Append(ch);
        }

        StringBuilder result = new StringBuilder();

        foreach (char ch in temp.ToString())
        {
            if (result.Length == 0 || result[result.Length - 1] != ch)
                result.Append(ch);
        }

        Console.WriteLine(result.ToString());
    }
}