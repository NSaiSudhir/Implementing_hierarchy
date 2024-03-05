using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_hierarchy
{
    public class Vehicle
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }

        // Behaviors (Methods)
        public void Registration()
        {
            Console.WriteLine($"This {Make} {Model} has a registration number");
        }

        public void Gas()
        {
            Console.WriteLine($"All {Make} {Model} has the gas type of petrol");
        }
    }

}
