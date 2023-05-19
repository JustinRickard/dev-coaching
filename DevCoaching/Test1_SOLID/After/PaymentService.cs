using DevCoaching.Test1_SOLID.Before.PaymentProviders;

namespace DevCoaching.Test1_SOLID.After
{
    public class PaymentService
    {
        
        private readonly ILogger _logger;
        private readonly IPaymentProviderProvider _paymentProviderProvider;
        private readonly IOrderFactory _orderFactory;
        public PaymentService(ILogger logger, IPaymentProviderProvider paymentProviderProvider, IOrderFactory orderFactory)
        {
            _logger = logger;
            _paymentProviderProvider = paymentProviderProvider;
            _orderFactory = orderFactory;
        }
        public void MakePayment(PaymentProviderType type, decimal amount)
        {
            var paymentProvider = _paymentProviderProvider.Provide(type);
            var order = _orderFactory.Create(type, amount);
            paymentProvider.ValidateOrder(order);
            paymentProvider.MakePayment(order);
            _logger.Log($"Payment made for {amount} to {type}");
            
        }
    }
}
