using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Inheritance_Interfaces.Before
{
    public abstract class Vehicle
    {
        public decimal LengthMetres { get; set; }
        public decimal WidthMetres { get; set; }
        public decimal WheelAngle { get; set; }

        public void ExampleSharedFunction()
        {

        }

        public abstract void Steer(decimal wheelAngle);
    }

    public class Car : Vehicle
    {
        public override void Steer(decimal wheelAngle)
        {
            WheelAngle = wheelAngle;
            // Do something car-specific
        }
    }

    public class Bus : Vehicle
    {
        public override void Steer(decimal wheelAngle)
        {
            WheelAngle = wheelAngle;
            // Do something bus-specific
        }
    }

    public class Train : Vehicle
    {
        public override void Steer(decimal wheelAngle)
        {
            // no logic here
        }

    }

    public class VehicleExample
    {
        private void UseVehicles()
        {
            var car = new Car();
            var bus = new Bus();
            var train = new Train();

            var vehicles = new List<Vehicle>();
            vehicles.Add(car);

            foreach (var vehicle in vehicles)
            {
                try
                {
                    vehicle.Steer(5);
                }
                catch
                {

                }
            }
        }
    }
}
