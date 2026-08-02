using System;
using System.Collections.Generic;

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();
    public static void Main(string[] args)
    {
        BikeUtility bikeUtility = new BikeUtility();
        int choice = 0;





        while (choice != 3)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            
            Console.WriteLine("Enter your choice");
            

            choice = Convert.ToInt32(Console.ReadLine());




            if (choice == 1)
            {
                
                Console.WriteLine("Enter the model");
                
                string? model = Console.ReadLine();

                
                Console.WriteLine("Enter the brand");
               
                string? brand = Console.ReadLine();
                
                Console.WriteLine("Enter the price per day");
                int price = Convert.ToInt32(Console.ReadLine());

                bikeUtility.AddBikeDetails(model, brand, price);

                
                Console.WriteLine("Bike details added successfully");
                
            }
            else if (choice == 2)
            {
                SortedDictionary<string, List<Bike>> groupedBikes = bikeUtility.GroupBikesByBrand();
                

                foreach (var brand in groupedBikes)
                {
                    Console.WriteLine($"Bikes Under: {brand.Key}");
                    
                    foreach (Bike bike in brand.Value)
                    {
                        Console.WriteLine(bike.Model);
                    }
                }        }
        }
    }
}

public class Bike
{
    public string? Model { get; set; }
    public string? Brand { get; set; }
    public int PricePerDay { get; set; }
}

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {

        int key = Program.bikeDetails.Count + 1;



        Bike bike = new Bike();
        bike.Model = model;
        bike.Brand = brand;
        bike.PricePerDay = pricePerDay;



        Program.bikeDetails.Add(key, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> Bikes = new SortedDictionary<string, List<Bike>>();

        foreach (Bike bike in Program.bikeDetails.Values)
        {
            if (!Bikes.ContainsKey(bike.Brand))
            {
                Bikes[bike.Brand] = new List<Bike>();
            }
            Bikes[bike.Brand].Add(bike);
        }

        return Bikes;
    }
}