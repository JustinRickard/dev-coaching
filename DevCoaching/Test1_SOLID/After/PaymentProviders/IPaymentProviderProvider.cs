using DevCoaching.Factories_Providers.Before;
using DevCoaching.Test1_SOLID.Before.PaymentProviders;

namespace DevCoaching.Test1_SOLID.After
{
    public interface IPaymentProviderProvider
    {
        IPaymentProvider Provide(PaymentProviderType type);
    }
}