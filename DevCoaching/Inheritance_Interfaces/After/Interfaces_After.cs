using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Inheritance_Interfaces.After
{

    public interface ISteerable
    {
        void Steer(decimal angle);
    }

    public abstract class Vehicle
    {
        public decimal LengthMetres { get; set; }
        public decimal WidthMetres { get; set; }

        public void ExampleSharedFunction()
        {

        }


    }

    public class Car2 : Vehicle, ISteerable
    {
        public void Steer(decimal angle)
        {

        }
    }

    public class Bus2 : Vehicle, ISteerable
    {
        public void Steer(decimal angle)
        {

        }
    }

    public class Train2 : Vehicle
    {

    }

    public class VehicleExample2
    {
        private void UseVehicles()
        {
            var car = new Car2();
            var bus = new Bus2();
            var train = new Train2();

            var vehicles = new List<ISteerable>();
            vehicles.Add(car);
            vehicles.Add(bus);


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

    // Example of Payment Provider interfaces

    public interface IPaymentProvider
    {
        void MakePayment(decimal amount);
    }

    public interface IStripePaymentProvider : IPaymentProvider
    {

    }
    public class StripePaymentProvider : IStripePaymentProvider
    {
        public void MakePayment(decimal amount)
        {

        }
    }


    public interface IWorldPayPaymentProvider : IPaymentProvider
    {

    }
    public class WorldPayPaymentProvider
    {
        public void MakePayment(decimal amount)
        {

        }
    }

    /*
     Dependency Injection registration:
     IStripePaymentProvider: StripePaymentProvider
     IWorldPayPaymentProvider: WorldPayPaymentProvider
    */
}

