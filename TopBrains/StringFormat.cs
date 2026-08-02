using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public record Student(string Name, int Score);

public class Program
{
    public static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        string[] items = new string[n];

        Console.WriteLine("Enter students in format Name:Score");
        for (int i = 0; i < n; i++)
        {
            items[i] = Console.ReadLine();
        }

        Console.Write("Enter minimum score: ");
        int minScore = int.Parse(Console.ReadLine());

        string json = GetStudentsJson(items, minScore);

        Console.WriteLine("\nFiltered JSON:");
        Console.WriteLine(json);
    }

    public static string GetStudentsJson(string[] items, int minScore)
    {
        List<Student> students = new List<Student>();

        foreach (string item in items)
        {
            string[] parts = item.Split(':');
            students.Add(new Student(parts[0], int.Parse(parts[1])));
        }

        var result = students
            .Where(s => s.Score >= minScore)
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();

        return JsonSerializer.Serialize(result);
    }
}