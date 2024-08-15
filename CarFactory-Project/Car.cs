using System;
using System.Collections.Generic;

namespace CarFactory_Project
{
    // Represents a car with various attributes
    public class Car
    {
        public DateTime ProductDate { get; set; }
        public int SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }

        // Constructor that sets the ProductDate to the current date and time
        public Car()
        {
            ProductDate = DateTime.Now;
        }
    }
}
