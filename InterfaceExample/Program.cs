using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hatchback h1 = new Hatchback("Skoda", "Citigo", "Midnight Blue", 2014,"OE14EYV");
            Bus b1 = new Bus("Mercedes", "Sprinter", "Black", 2022, "BD22SVJ", 24, 16);

            Console.WriteLine($"Hatchback 1 Details \nMake:{h1.Make}\nModel:{h1.Model}\nColour:{h1.Colour}\nYear: {h1.Year} \nLicense Plate: {h1.LicensePlate}");
            Console.WriteLine($"Bus 1 Details \nMake:{b1.Make}\nModel:{b1.Model}\nColour:{b1.Colour}\nYear: {b1.Year} \nLicense Plate: {b1.LicensePlate} \nAvailable Seats: {b1.EmptySeats}");
        }
    }
}
