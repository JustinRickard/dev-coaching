using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Factories_Providers.After
{
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

    public enum PaymentProviderType
    {
        Stripe,
        WorldPay
    }

    public class ExamplePaymentClass
    {
        private readonly IServiceProvider _serviceProvider;

        public ExamplePaymentClass(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void MakePayment(PaymentProviderType type, decimal amount)
        {
            IPaymentProvider paymentProvider;

            switch (type)
            {
                case PaymentProviderType.Stripe:
                    paymentProvider = GetService<IStripePaymentProvider>();
                    break;
                case PaymentProviderType.WorldPay:
                    paymentProvider = GetService<IWorldPayPaymentProvider>();
                    break;
                default:
                    throw new Exception("Invalid Provider");
            }

            ProcessOrder(paymentProvider);
        }

        protected T GetService<T>() => (T)_serviceProvider.GetService(typeof(T));

        public void ProcessOrder(IPaymentProvider paymentProvider)
        {

        }
    }

}
