using System;

namespace CodeTest
{
    class CarWriter : IVehicleOutputter
    {
        public void Output(Vehicle vehicle)
        {
            Console.WriteLine();
            Console.WriteLine($"Car: {vehicle.Registration} ({vehicle.VehicleClass})");
            Console.WriteLine($"  Engine power : {vehicle.EnginePower} kW");
            Console.WriteLine($"  Maximum speed: {vehicle.MaximumSpeed} {vehicle.SpeedUnit}");
            Console.WriteLine($"  Colour       : {(vehicle as Car).Colour}");
        }
    }

}
