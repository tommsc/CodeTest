using System;

namespace CodeTest
{
    class Plane : Vehicle
    {
        public int Wingspan { get; set; }
        public int LoadCapacity { get; set; }
        public int NetWeight { get; set; }

        public Plane(int wingspan,
                     int loadCapacity,
					 int netWeight,
				     VehicleController controller,
					 IVehicleOutputter printer)
            : base(controller, printer)
        {
            Wingspan = wingspan;
            LoadCapacity = loadCapacity;
            NetWeight = netWeight;
        }

        public override void Go()
        {
            Console.WriteLine($"{Registration} is flying..."); // autopilot
		}

        public void Fly()
        {
            Go();
        }

    }
}
