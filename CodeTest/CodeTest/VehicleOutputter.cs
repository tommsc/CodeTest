using System;
namespace CodeTest
{
	public interface IVehicleOutputter
	{
		void Output(Vehicle vehicle);
	}

	public class VehiclePrinter : IVehicleOutputter
	{
		public void Output(Vehicle vehicle)
		{
			Console.WriteLine($"Vehicle: {vehicle.Registration} ({vehicle.VehicleClass})");
		}
	}
}
