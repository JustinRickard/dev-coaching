using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Attributes.Before
{
	public class Order
	{
		public decimal Amount { get; set; }
		public decimal Surcharge { get; set; }
		public decimal ExtraLevy { get; set; }
		public decimal TaxFreeDonation { get; set; }
	}

	public class TaxCalculator
	{
		private const decimal VatRate = 0.2M;

		public decimal Calculate(Order order)
		{
			// No tax applied to ExtraLevy or TaxFreeDonation.
			// VAT on Amount and Surcharge
			return Convert.ToDecimal(
				(order.Amount * VatRate) +
				(order.Surcharge * VatRate)
			);
		}
	}
}
