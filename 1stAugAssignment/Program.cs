using System;
namespace banksys
{
    class Account
    {
        private string name;
        private double balance;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public double deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Error: Deposit amount must be greater than zero.");
            }
            return balance;
        }
        public double getBalance()
        {
            return balance;
        }
        public string setName(string name)
        {
            this.name = name;
            return name;
        }
        public string getName()
        {
            return name;
        }



        public static void Main(string[] args)
        {


            Account account = new Account("John Doe", 1000.0);
            Console.WriteLine(account.deposit(250.0));
            Console.WriteLine(account.getName());


            Account account2 = new Account("Amit", 500.0);
            Console.WriteLine(account2.getBalance());
            Console.WriteLine(account2.deposit(0.5));
            Console.WriteLine(account2.getBalance());

            Account account3 = new Account("Siya Amit Mehta ", 800.0);
            Console.WriteLine(account3.getName());

            
        }
    }
}