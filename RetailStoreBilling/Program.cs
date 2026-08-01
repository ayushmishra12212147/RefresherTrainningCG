using System;
public class Program
{
    public static void Main(string[] args)
    {
        double amount=0;
        int quantity=0;
        double discount=0;

        Console.WriteLine("Enter the amount:");
        if(!double.TryParse(Console.ReadLine(), out amount))
        {
            Console.WriteLine("Invalid input for amount.");
            return;
        }
        if(amount<0)
        {
            Console.WriteLine("Amount cannot be negative.");
            return;
        }

        Console.WriteLine("Enter the quantity:");
        if(!int.TryParse(Console.ReadLine(), out quantity))
        {
            Console.WriteLine("Invalid input for quantity.");
            return;
        }
        if(quantity<0)
        {
            Console.WriteLine("Quantity cannot be negative.");
            return;
        }

        Console.WriteLine("Enter the discount percentage:");
        if(!double.TryParse(Console.ReadLine(), out discount))
        {
            Console.WriteLine("Invalid input for discount.");
            return;
        }
        if(discount<0 || discount>100)
        {
            Console.WriteLine("Discount percentage must be between 0 and 100.");
            return;
        }

        double totalAmount = amount * quantity;
        double discountAmount = totalAmount * (discount / 100);
        double finalAmount = totalAmount - discountAmount;

        Console.WriteLine("Total Amount: {0}", totalAmount);
        Console.WriteLine("Discount Amount: {0}", discountAmount);
        Console.WriteLine("Final Amount: {0}", finalAmount);

    }
}