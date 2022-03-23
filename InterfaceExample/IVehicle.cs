using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    interface IVehicle
    {
        public string Make { get; }
        public string Model { get; }
        public string Colour { get; }
        public int Year { get; }
        public string LicensePlate { get; }



    }
}
