using System;

namespace CodeTest
{
    public interface IVehicleController
	{
		void Go();
	}

	public class VehicleController : IVehicleController
	{
		public string Registration { get; set; }
		public string VehicleClass { get; set; }
		public int EnginePower { get; set; }
		public int MaximumSpeed { get; set; }
		public string SpeedUnit { get; set; }

		public VehicleController(string registration, string vehicleClass, 
                                 int enginePower, int maximumSpeed, string speedUnit)
		{
            Registration = registration;
            VehicleClass = vehicleClass;
			EnginePower = enginePower;
			MaximumSpeed = maximumSpeed;
			SpeedUnit = speedUnit;
		}

		public void Go() { }
	}
}
