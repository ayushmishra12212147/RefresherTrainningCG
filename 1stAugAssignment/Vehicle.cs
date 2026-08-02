using System;

class ParkingVehicle
{
    public string VehicleName;
    public double Hours;
    public double HourlyRate;
    public double DailyMaximum;

    public ParkingVehicle(string vehicleName, double hours, double hourlyRate, double dailyMaximum)
    {
        VehicleName = vehicleName;
        Hours = hours;
        HourlyRate = hourlyRate;
        DailyMaximum = dailyMaximum;
    }

    public void DisplayFee()
    {
        double fee = 0;

        if (Hours > 0.5)
        {
            fee = (Hours - 0.5) * HourlyRate;
        }

        if (fee > DailyMaximum)
        {
            fee = DailyMaximum;
        }

        if (Hours > 8)
        {
            fee = fee * 0.90;
        }

        Console.WriteLine("Vehicle:" + VehicleName);
        Console.WriteLine("Parking Duration:" + Hours.ToString("F2") + " hours");
        Console.WriteLine("Hourly Rate: " + HourlyRate.ToString("F2"));
        Console.WriteLine("Daily Maximum: " + DailyMaximum.ToString("F2"));
        Console.WriteLine("Total Fee: " + fee.ToString("F2"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PARKING FEE CALCULATOR ===\n");

        ParkingVehicle v1 = new ParkingVehicle("Car", 2.5, 3, 25);
        ParkingVehicle v2 = new ParkingVehicle("Car", 12, 3, 25);
        ParkingVehicle v3 = new ParkingVehicle("Motorcycle", 4, 2, 15);
        ParkingVehicle v4 = new ParkingVehicle("Truck", 6.5, 5, 40);
        ParkingVehicle v5 = new ParkingVehicle("Car", 0.25, 3, 25);
        ParkingVehicle v6 = new ParkingVehicle("Motorcycle", 10, 2, 15);

        v1.DisplayFee();
        v2.DisplayFee();
        v3.DisplayFee();
        v4.DisplayFee();
        v5.DisplayFee();
        v6.DisplayFee();
    }
}