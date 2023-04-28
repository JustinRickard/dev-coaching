using DevCoaching.Test1_SOLID.Before.PaymentProviders;

namespace DevCoaching.Test1_SOLID.Before
{
    public class PaymentService
    {
        public void MakePayment(PaymentProviderType type, decimal amount)
        {
            if (type == PaymentProviderType.Stripe)
            {
                Log($"About to make payment to Stripe");
                new StripePaymentProvider().MakePayment(amount);
                Log($"Payment made to Stripe for {amount}");
            }
            else if (type == PaymentProviderType.WorldPay)
            {
                Log($"About to make payment to World Pay");
                new WorldPayPaymentProvider().MakePayment(amount);
                Log($"Payment made to World Pay for {amount}");
            }
            else if (type == PaymentProviderType.Square)
            {
                Log($"About to make payment to Square");
                new SquarePaymentProvider().MakePayment(amount);
                Log($"Payment made to Square for {amount}");
            }
            else if (type == PaymentProviderType.GoCardless)
            {
                Log($"About to make payment to Go Cardless");
                new GoCardlessPaymentProvider().MakePayment(amount);
                Log($"Payment made to Go Cardless for {amount}");
            }
            else
            {
                throw new Exception("Invalid payment type");
            }
        }

        private void Log(string message)
        {
        }
    }
}
