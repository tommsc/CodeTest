using System;

namespace CodeTest
{
    class BoatWriter : IVehicleOutputter
    {
        public void Output(Vehicle vehicle)
        {
			Console.WriteLine();
			Console.WriteLine($"Boat: {vehicle.Registration} ({vehicle.VehicleClass})");
            Console.WriteLine($"  Engine power : {vehicle.EnginePower} kW");
            Console.WriteLine($"  Maximum speed: {vehicle.MaximumSpeed} {vehicle.SpeedUnit}");
            Console.WriteLine($"  Gross tonnage: {(vehicle as Boat).GrossTonnage:0.0} kg");
        }
    }

}
