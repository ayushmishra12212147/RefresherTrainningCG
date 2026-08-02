using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
}

public class Solution
{
    static List<Book> books = new List<Book>();

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Update Book");
            Console.WriteLine("5. Delete Book");
            Console.WriteLine("6. Exit");

            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    ViewBooks();
                    break;
                case 3:
                    SearchBook();
                    break;
                case 4:
                    UpdateBook();
                    break;
                case 5:
                    DeleteBook();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Book book = new Book();

        Console.Write("Book Id: ");
        book.BookId = int.Parse(Console.ReadLine());

        Console.Write("Title: ");
        book.Title = Console.ReadLine();

        Console.Write("Author: ");
        book.Author = Console.ReadLine();

        Console.Write("Category: ");
        book.Category = Console.ReadLine();

        books.Add(book);

        Console.WriteLine("Book Added Successfully");
    }

    static void ViewBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No Books Available");
            return;
        }

        foreach (dynamic book in books)
        {
            Console.WriteLine($"{book.BookId} | {book.Title} | {book.Author} | {book.Category}");
        }
    }

    static void SearchBook()
    {
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        var result = books.Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        foreach (dynamic book in result)
        {
            Console.WriteLine($"{book.BookId} | {book.Title} | {book.Author} | {book.Category}");
        }

        if (!result.Any())
            Console.WriteLine("Book Not Found");
    }

    static void UpdateBook()
    {
        Console.Write("Enter Book Id: ");
        int id = int.Parse(Console.ReadLine());

        Book book = books.FirstOrDefault(b => b.BookId == id);

        if (book == null)
        {
            Console.WriteLine("Book Not Found");
            return;
        }

        Console.Write("New Title: ");
        book.Title = Console.ReadLine();

        Console.Write("New Author: ");
        book.Author = Console.ReadLine();

        Console.Write("New Category: ");
        book.Category = Console.ReadLine();

        Console.WriteLine("Book Updated Successfully");
    }

    static void DeleteBook()
    {
        Console.Write("Enter Book Id: ");
        int id = int.Parse(Console.ReadLine());

        Book book = books.FirstOrDefault(b => b.BookId == id);

        if (book == null)
        {
            Console.WriteLine("Book Not Found");
            return;
        }

        books.Remove(book);

        Console.WriteLine("Book Deleted Successfully");
    }
}