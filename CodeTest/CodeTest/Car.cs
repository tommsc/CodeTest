using System;

namespace CodeTest
{
    class Car : Vehicle
    {
        public string Colour { get; set; }

        public Car(string colour, 
                   VehicleController controller,
                   IVehicleOutputter printer)
            : base(controller, printer)
        {
            Colour = colour;
        }

        public void Drive()
        {
            Go();
        }

        public override void Go()
        {
            Console.WriteLine($"{Registration} is autonomously driving...");
        }

    }

}
