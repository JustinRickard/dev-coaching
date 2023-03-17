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

    public interface IPaymentProviderProvider
    {
        IPaymentProvider Provide(PaymentProviderType type);
    }

    public class PaymentProviderProvider
    {
        private readonly IServiceProvider _serviceProvider;

        public PaymentProviderProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPaymentProvider Provide(PaymentProviderType type)
        {
            switch (type)
            {
                case PaymentProviderType.Stripe:
                    return GetService<IStripePaymentProvider>();
                case PaymentProviderType.WorldPay:
                    return GetService<IWorldPayPaymentProvider>();
                default:
                    throw new Exception("Invalid Provider");
            }
        }

        protected T GetService<T>() => (T)_serviceProvider.GetService(typeof(T));
    }

    public class ExamplePaymentClass
    {
        private readonly IPaymentProviderProvider _provider;

        public ExamplePaymentClass(IPaymentProviderProvider provider)
        {
            _provider = provider;
        }

        

        public void MakePayment(PaymentProviderType type, decimal amount)
        {
            var paymentProvider = _provider.Provide(type);
            ProcessOrder(paymentProvider);
            // Extra
        }

        

        public void ProcessOrder(IPaymentProvider paymentProvider)
        {

        }
    }

}
