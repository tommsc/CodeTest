using System;

namespace CodeTest
{
    class Boat : Vehicle
    {
        public double GrossTonnage { get; set; }

        public Boat(double grossTonnage,
				    VehicleController controller,
					IVehicleOutputter printer)
            : base(controller, printer)
        {
            GrossTonnage = grossTonnage;
        }

        public void Disembark()
        {
            Go();
        }

        public override void Go()
        {
            // Start autonoumos journey
            Console.WriteLine($"{Registration} has disembarked...");
        }

    }
}
