using DevCoaching.Factories_Providers.Before;
using DevCoaching.Test1_SOLID.Before.PaymentProviders;

namespace DevCoaching.Test1_SOLID.After
{
    public class PaymentService
    {
        private readonly IPaymentProviderProvider _paymentProviderProvider;
        private readonly ILogger _logger;

        public PaymentService(IPaymentProviderProvider paymentProviderProvider, ILogger logger)
        {
            _paymentProviderProvider = paymentProviderProvider;
            _logger = logger;
        }   
        
        public void MakePayment(PaymentProviderType type, decimal amount)
        {
            _paymentProviderProvider.Provide(type).MakePayment(amount);
            _logger.Log($"Payment of {amount} made using {type} provider.");
        }

    }
}
