using DevCoaching.Test1_SOLID.Before.PaymentProviders;

namespace DevCoaching.Test1_SOLID.After
{
    public class PaymentService
    {
        public void MakePayment(PaymentProviderType type, decimal amount)
        {
            if (type == PaymentProviderType.Stripe)
            {
                Log($"About to make payment to Stripe");
                var stripeOrder = new StripeOrder { Amount = amount };
                new StripePaymentProvider().MakePayment(stripeOrder);
                Log($"Payment made to Stripe for {amount}");
            }
            else if (type == PaymentProviderType.WorldPay)
            {
                Log($"About to make payment to World Pay");
                var worldPayOrder = new WorldPayOrder() { Amount = amount };
                new WorldPayPaymentProvider().MakePayment(worldPayOrder);
                Log($"Payment made to World Pay for {amount}");
            }
            else if (type == PaymentProviderType.Square)
            {
                Log($"About to make payment to Square");
                var squareOrder = new SquareOrder { Amount = amount };
                new SquarePaymentProvider().MakePayment(squareOrder);
                Log($"Payment made to Square for {amount}");
            }
            else if (type == PaymentProviderType.GoCardless)
            {
                Log($"About to make payment to Go Cardless");
                var goCardlessOrder = new GoCardlessOrder() { Amount = amount };
                new GoCardlessPaymentProvider().MakePayment(goCardlessOrder);
                Log($"Payment made to Go Cardless for {amount}");
            }
            else
            {
                throw new Exception("Invalid payment type");
            }
        }

        public void ValidateOrder(PaymentProviderType type, decimal amount)
        {
            switch (type)
            {
                case PaymentProviderType.WorldPay:
                    if (amount > 1_000) throw new Exception("Order can't be above £1,000");
                    break;
                case PaymentProviderType.Stripe:
                    if (amount > 2_000) throw new Exception("Order can't be above £2,000");
                    break;
                case PaymentProviderType.Square:
                    if (amount > 3_000) throw new Exception("Order can't be above £3,000");
                    break;
                case PaymentProviderType.GoCardless:
                    if (amount > 4_000) throw new Exception("Order can't be above £4,000");
                    break;
                default:
                    throw new Exception("Invalid payment type");
            }
        }

        private void Log(string message)
        {
        }
    }
}
