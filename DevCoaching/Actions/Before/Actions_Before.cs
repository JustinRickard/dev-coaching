using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevCoaching.Attributes.After;

namespace DevCoaching.Actions.Before
{
	public class Order
	{
		public string Id { get; set; }
		public int Status { get; set; }
		public decimal Amount { get; set; }

	}
	public class OrderProcessor
	{
		public void Process(Order order)
		{
			// Do something 1

			switch (order.Status)
			{
				case 1:
					DoSomething1(order.Amount);
					break;
				case 2:
					DoSomething2(order.Amount);
					break;
				default: throw new NotImplementedException();
			}

			// Do something 3
		}

		private void DoSomething1(decimal amount){}
		private void DoSomething2(decimal amount) { }
	}
}
