namespace Implementing_hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Vehicle
            Vehicle myVehicle = new Vehicle
            {
                Make = "Honda",
                Model = "Civic"
            };

            // Use Vehicle behaviors
            myVehicle.Registration();
            myVehicle.Gas();

            // Create an instance of Car
            Car myCar = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                FuelCapacity = 50,
                LicensePlate = "ABC123"
            };

            
            myCar.Registration();
            myCar.Gas();     
            myCar.platenumber();
            myCar.Refuel();
        }
    }
}
