using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Test1_SOLID.After.PaymentProviders
{
    public class GoCardlessPaymentProvider
    {
        public void MakePayment(IOrder order)
        {
        }
        public void ValidateOrder(IOrder order)
        {
            if (order.Amount > 4_000)
                throw new Exception("Order can't be above £4,000");
        }
    }

    public class GoCardlessOrder : Order
    {
        public string Id { get; set; }
        public string Sku { get; set; }
        public decimal Amount { get; set; }
        public string GoCardlessCustomField { get; set; }
    }
}
