using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Hatchback : IVehicle
    {
        public string Make { get; }
        public string Model { get; }
        public string Colour { get; }
        public string LicensePlate { get; }
        public int Year { get; }

        public void Honk()
        {
            Console.WriteLine("HONK HONNNKKK!!!");
        }

        public Hatchback(string make, string model, string colour, int year,  string licensePlate)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Year = year;
            LicensePlate = licensePlate;
        }
    }
}
