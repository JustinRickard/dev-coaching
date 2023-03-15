

namespace DevCoaching.Factories_Providers.Before
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

    public class ExampleClass
    {
        private Vehicle CreateVehicle(VehicleType type)
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

            Service(vehicle);

            return vehicle;
        }

        private void Service(Vehicle v)
        {

        }
    }
}
