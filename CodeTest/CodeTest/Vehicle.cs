using System;

namespace CodeTest
{
    public abstract class Vehicle
    {
        public string Registration => _controller.Registration;
        public string VehicleClass => _controller.VehicleClass;
        public int EnginePower => _controller.EnginePower; 
        public int MaximumSpeed => _controller.MaximumSpeed;
        public string SpeedUnit => _controller.SpeedUnit;

		VehicleController _controller;
        IVehicleOutputter _writer;

		protected Vehicle() { }

        public Vehicle(VehicleController controller, IVehicleOutputter writer)
        {
            _controller = controller;
            _writer = writer;
        }

        public virtual void Go() { }

		public virtual void Write()
		{
			_writer.Output(this);
		}
	}

}
