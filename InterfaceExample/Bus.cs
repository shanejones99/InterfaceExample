using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Bus : IVehicle
    {
        public string Make { get; }
        public string Model { get; }
        public string Colour { get; }
        public int Year { get; }
        public string LicensePlate { get; }

        public int NumberOfSeats { get; }
        public int NumberOfPassengers { get; }

        public int EmptySeats { get; private set; }

        public void Honk()
        {
            Console.WriteLine("HONK HONNNKKK!!!");
        }

        
        public Bus( string make, string model, string colour, int year, string licenseplate, int numberOfSeats, int numberOfPassengers)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Year = year;
            LicensePlate = licenseplate; 
            NumberOfSeats = numberOfSeats;
            NumberOfPassengers = numberOfPassengers;
            EmptySeats = CalculateEmptySeats( numberOfPassengers, numberOfSeats);
        }

        public int CalculateEmptySeats(int passengers, int seats)
        {
            int numberOfEmptySeats = seats - passengers;
            return numberOfEmptySeats;
        }

    }
}
