using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Test1_SOLID.After.PaymentProviders
{
    public class WorldPayPaymentProvider
    {
        public void MakePayment(IOrder order)
        {
        }
        public void ValidateOrder(IOrder order)
        {
            if (order.Amount > 1_000)
                throw new Exception("Order can't be above £1,000");
        }

        
    }
    public class WorldPayOrder : Order
    {
        public string Id { get; set; }
        public string Sku { get; set; }
        public decimal Amount { get; set; }
        public string WorldPayCustomField { get; set; }
    }
}
