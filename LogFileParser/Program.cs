using System;

enum LogLevel
{
    INFO,
    WARNING,
    ERROR
}

static class LogParser
{
    public static bool ParseLogLine(in string logLine, out DateTime timestamp,
        out LogLevel level, ref int counter)
    {
        timestamp = DateTime.MinValue;
        level = LogLevel.INFO;

        counter++;

        string[] parts = logLine.Split(' ');

        if (parts.Length < 3)
            return false;

        if (!DateTime.TryParse(parts[0] + " " + parts[1], out timestamp))
            return false;

        string logLevel = parts[2].Replace(":", "");

        if (!Enum.TryParse(logLevel, true, out level))
            return false;

        return true;
    }
}

class Program
{
    static void Main()
    {
        string log = "2023-10-27 14:30:00 ERROR: Disk full";

        int counter = 0;

        if (LogParser.ParseLogLine(in log, out DateTime time,
            out LogLevel level, ref counter))
        {
            Console.WriteLine($"{time}");
            Console.WriteLine($"{level}");
            Console.WriteLine($"{counter}");
        }
        else
        {
            Console.WriteLine("Invalid Log.");
        }
    }
}