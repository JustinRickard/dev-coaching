using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevCoaching.Test1_SOLID.After;

namespace DevCoaching.Test1_SOLID.Before.PaymentProviders
{
    public class GoCardlessPaymentProvider_After : IGoCardlessPaymentProviderAfter
    {
        public void MakePayment(decimal amount)
        {
        }
    }
}
