using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Test1_SOLID.After.PaymentProviders
{
    public class StripePaymentProvider
    {
        public void MakePayment(StripeOrder order)
        {
        }
    }

    public class StripeOrder
    {
        public string Id { get; set; }
        public string Sku { get; set; }
        public decimal Amount { get; set; }
        public string StripeCustomField { get; set; }
    }
}
