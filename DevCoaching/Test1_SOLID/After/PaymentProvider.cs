using DevCoaching.Test1_SOLID.After.PaymentProviders;

namespace DevCoaching.Test1_SOLID.After;

public interface IPaymentProvider
{
    void MakePayment(IOrder order);
    void ValidateOrder(IOrder order);
}