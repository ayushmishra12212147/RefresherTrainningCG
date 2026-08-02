using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        input = input.Trim();

        StringBuilder sb = new StringBuilder();

        foreach (char ch in input)
        {
            if (sb.Length == 0 || sb[sb.Length - 1] != ch)
                sb.Append(ch);
        }

        string result = string.Join(" ", sb.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result.ToLower());

        Console.WriteLine(result);
    }
}