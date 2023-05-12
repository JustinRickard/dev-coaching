using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevCoaching.Factories_Providers.Before;

namespace DevCoaching.Test1_SOLID.After.PaymentProviders
{
    public class StripePaymentProvider_After : IStripePaymentProvider
    {
        public void MakePayment(decimal amount)
        {
        }
    }
}

