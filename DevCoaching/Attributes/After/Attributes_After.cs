using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Attributes.After
{
    public class Attributes_After
    {
        public class Order
        {
            [Taxable]
            public decimal Amount { get; set; }

            [Taxable]
            public decimal Surcharge { get; set; }

            public decimal ExtraLevy { get; set; }
            public decimal TaxFreeDonation { get; set; }
        }

        public class TaxCalculator
        {
            private const decimal VatRate = 0.2M;

            public decimal Calculate(Order order)
            {
                var fields = order.GetType().GetFields();

                decimal total = 0;
                foreach (var field in fields)
                {
                    if (field.GetCustomAttributes(typeof(TaxableAttribute), false).Any())
                    {
                        total += (decimal)field.GetValue(order);
                    }
                }

                return total;

                /* Or in 1-line using LiNQ
                return order.GetType().GetFields().Select(f => f
                    .GetCustomAttributes(typeof(TaxableAttribute), false).Any()
                        ? (decimal)f.GetValue(order)
                        : 0)
                    .Sum();
                */
            }
        }
    }
}
