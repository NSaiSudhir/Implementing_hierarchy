using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_hierarchy
{
    public class Car : Vehicle // Inheriting from Vehicle class
    {
        
        public int FuelCapacity { get; set; }
        public string LicensePlate { get; set; }

        // Behaviors (Methods) specific to Car
        public void platenumber()
        {
            Console.WriteLine($"{Make} {Model} has the regestration number {LicensePlate}");
        }

        public void Refuel()
        {
            Console.WriteLine($"{Make} {Model} Has the fueling capasity of {FuelCapacity} liters.");
        }
    }
}
