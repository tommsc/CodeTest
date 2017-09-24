/*
 • Print information about a car (car 1) with licence plate NF123456, 147 kW engine power, maximal speed of 200 km/h, green colour and type of personal vehicle
 • Print information about another car (car 2) with licence plate NF654321, 150 kW engine power, maximal speed of 195 km/h, blue colour and type of personal vehicle
 • Compare these two cars to check if this is the same vehicle
 • Print information about a plane with registration LN1234, 1000 kW engine power, 30m wingspan, 2t load capacity and 10t net weight, flying class of jet plane
 • Application should ask the plane to fly and print this
 • Application should ask the car 1 to drive and print this
 • Print information about a boat with registration ABC123, 100 kW engine power, maximal speed of 30 knot per hour and 500 kg gross tonnage
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CodeTest - TW Fleet\n");

            // Create four different vehicles
            Car car1 = new Car("Green", 
                               new VehicleController("NF123456", "Personal car", 147, 200, "km/h"), 
                               new CarWriter());

            Car car2 = new Car("Blue", 
                               new VehicleController("NF654321", "Personal car", 150, 195, "km/h"), 
                               new CarWriter());

            int wingspan = 30;
            int loadCapacity = 2;
            int netWeight = 10;
            Plane plane = new Plane(wingspan, loadCapacity, netWeight, 
                                    new VehicleController("LN1234", "Jet plane", 1000, 0, ""), 
                                    new PlaneWriter());

            double GRT = 500.0;
            Boat boat = new Boat(GRT, 
                                 new VehicleController("ABC123", "Boat", 100, 30, "knot/h"), 
                                 new BoatWriter());

            // Create a vehicle fleet 
            var vehicles = new List<Vehicle> { car1, car2, plane, boat };

            // Check that cars are different vehicles (maybe implement an EqualityComparer?)
            Debug.Assert(car1.Registration != car2.Registration, 
                "The vehicles compared refer to the same vehicle: " + car1.Registration);

            // Launch car1 and plane with specific class commands
            car1.Drive();
            plane.Fly();

            // Launch car2 and boat with generic vehicle commands
            vehicles[1].Go();
            vehicles[3].Go();

            // Print all fleet details
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Write();
            }

            Console.Read();
        }
    }
}

