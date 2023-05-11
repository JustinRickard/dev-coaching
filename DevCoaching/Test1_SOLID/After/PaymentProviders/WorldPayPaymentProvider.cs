using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Test1_SOLID.After.PaymentProviders
{
    public class WorldPayPaymentProvider
    {
        public void MakePayment(WorldPayOrder order)
        {
        }
    }

    public class WorldPayOrder
    {
        public string Id { get; set; }
        public string Sku { get; set; }
        public decimal Amount { get; set; }
        public string WorldPayCustomField { get; set; }
    }
}
