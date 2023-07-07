using DevCoaching.Inheritance_Interfaces.After;
using DevCoaching.Test1_SOLID.After.PaymentProviders;
using GoCardlessOrder = DevCoaching.Test1_SOLID.After.PaymentProviders.GoCardlessOrder;
using SquareOrder = DevCoaching.Test1_SOLID.After.PaymentProviders.SquareOrder;
using StripeOrder = DevCoaching.Test1_SOLID.After.PaymentProviders.StripeOrder;
using WorldPayOrder = DevCoaching.Test1_SOLID.After.PaymentProviders.WorldPayOrder;

namespace DevCoaching.Test1_SOLID.After;

public interface IOrderFactory
{
    Order Create(PaymentProviderType type, decimal amount);
}

public class OrderFactory : IOrderFactory
{
    public Order Create(PaymentProviderType type, decimal amount)
    {

        Order order;

        switch (type)
        {
            case PaymentProviderType.Stripe:
                order = new StripeOrder(){Amount = amount};
                break;
            case PaymentProviderType.WorldPay:
                order = new WorldPayOrder(){Amount = amount};
                break;
            case PaymentProviderType.Square:
                order = new SquareOrder(){Amount = amount};
                break;
            case PaymentProviderType.GoCardless:
                order = new GoCardlessOrder(){Amount = amount};
                break;
            default: throw new Exception("Invalid Type");
        }

        return order;
    }
}