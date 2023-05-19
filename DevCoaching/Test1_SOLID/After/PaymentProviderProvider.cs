using System;
using DevCoaching.Factories_Providers.Before;
using DevCoaching.Test1_SOLID.Before.PaymentProviders;

namespace DevCoaching.Test1_SOLID.After
{
    public interface IPaymentProviderProvider
    {
        IPaymentProvider Provide(PaymentProviderType type);
    }
    
    public class PaymentProviderProvider : IPaymentProviderProvider
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
                    return GetService<IStripePaymentProviderAfter>();
                case PaymentProviderType.WorldPay:
                    return GetService<IWorldPayPaymentProvideAfter>();
                case PaymentProviderType.Square:
                    return GetService<ISquarePaymentProviderAfter>();
                case PaymentProviderType.GoCardless:
                    return GetService<IGoCardlessPaymentProviderAfter>();
                default:
                    throw new Exception("Invalid Provider");
            }
        }

        protected T GetService<T>() => (T)_serviceProvider.GetService(typeof(T));
    }

    public interface IWorldPayPaymentProvideAfter : IPaymentProvider
    {
    }

    public interface IStripePaymentProviderAfter : IPaymentProvider
    {
    }

    public interface ISquarePaymentProviderAfter : IPaymentProvider
    {
    }

    public interface IGoCardlessPaymentProviderAfter : IPaymentProvider
    {
    }

}