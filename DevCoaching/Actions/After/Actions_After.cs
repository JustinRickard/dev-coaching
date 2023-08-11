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

		private readonly Dictionary<int, Func<decimal, decimal>> _doSomethingStatusToFunctions = new()
		{
			{ 1, DoSomethingFunc1 },
			{ 2, DoSomethingFunc2 }
		};

		public void Process(Order order, Action<decimal> doSomethingWeird, Func<decimal, decimal> doSomeFunc)
		{
			// Do something 1

			doSomethingWeird(
				doSomeFunc(order.Amount));

			// Do something 3
		}

		private static void DoSomething1(decimal amount) { }
		private static void DoSomething2(decimal amount) { }

		private static decimal DoSomethingFunc1(decimal amount)
		{
			return 7; }

		private static decimal DoSomethingFunc2(decimal amount)
		{
			return 8;
		}
	}
}
