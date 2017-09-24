using System;

namespace CodeTest
{
    class PlaneWriter : IVehicleOutputter
    {
        public void Output(Vehicle vehicle)
        {
			Console.WriteLine();
			Console.WriteLine($"Plane: {vehicle.Registration} ({vehicle.VehicleClass})");
            Console.WriteLine($"  Engine power : {vehicle.EnginePower} kW");

            if (vehicle.MaximumSpeed > 0)
            {
                Console.WriteLine($"  Maximum speed: {vehicle.MaximumSpeed} {vehicle.SpeedUnit}");
            }
            Console.WriteLine($"  Wingspan     : {(vehicle as Plane).Wingspan} m");
            Console.WriteLine($"  Load capacity: {(vehicle as Plane).LoadCapacity} t");
            Console.WriteLine($"  Net weight   : {(vehicle as Plane).NetWeight} t");
        }
    }
}
