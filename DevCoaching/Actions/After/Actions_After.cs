using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Actions.After
{
	public class Order
	{
		public string Id { get; set; }
		public int Status { get; set; }
		public decimal Amount { get; set; }

	}
	public class OrderProcessor
	{
		private readonly Dictionary<int, Action<decimal>> _doSomethingStatusToActions = new()
		{
			{ 1, DoSomething1 },
			{ 2, DoSomething2 }
		};

		public void Process(Order order)
		{
			// Do something 1

			_doSomethingStatusToActions[order.Status](order.Amount);

			// Do something 3
		}

		private static void DoSomething1(decimal amount) { }
		private static void DoSomething2(decimal amount) { }
	}
}
