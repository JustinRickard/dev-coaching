using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Factories_Providers.After
{
    public abstract class Vehicle
    {
    }

    public class Car : Vehicle
    {
    }

    public class Bus : Vehicle
    {
    }

    public class Train : Vehicle
    {
    }

    public enum VehicleType
    {
        Car,
        Bus,
        Train,
    }

    public interface IVehicleFactory
    {
        Vehicle Create(VehicleType type);
    }

    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle Create(VehicleType type)
        {
            Vehicle vehicle;

            switch (type)
            {
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Bus:
                    vehicle = new Bus();
                    break;
                case VehicleType.Train:
                    vehicle = new Train();
                    break;
                default: throw new Exception("Invalid Type");
            }

            // extra processing
            return vehicle;
        }
    }

    public class ExampleClass
    {
        private readonly IVehicleFactory _vehicleFactory;

        public ExampleClass(IVehicleFactory vehicleFactory)
        {
            _vehicleFactory = vehicleFactory;
        }

        private Vehicle CreateVehicle(VehicleType type)
        {
            var vehicle = _vehicleFactory.Create(type);

            Service(vehicle);

            return vehicle;
        }

        private void Service(Vehicle v)
        {

        }
    }
}
