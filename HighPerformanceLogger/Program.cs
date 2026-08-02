using System;

static class Logger
{
    public static string FormatLogMessage(string template, params object[] args)
    {
        string result = template;
        void ReplacePlaceholders()
        {
            for (int i = 0; i < args.Length; i++)
            {
                result = result.Replace("{" + i + "}", args[i]?.ToString());
                if (int.TryParse(args[i]?.ToString(), out int value))
                {Console.WriteLine($"Argument {i} is Integer : {value}");
                }
            }
        }
        ReplacePlaceholders();
        return result;
    }
}

class Program
{
    static void Main()
    {
        string message = Logger.FormatLogMessage(
            "User {0} logged in from {1} at {2}",
            "JohnDoe",
            "192.168.1.1",
            DateTime.Now
        );
        Console.WriteLine(message);
    }
}