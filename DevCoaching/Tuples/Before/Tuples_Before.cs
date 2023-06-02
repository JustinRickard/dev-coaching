using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Tuples.Before
{
	public class ProcessOrderCommand
	{
		public Guid OrderId { get; set; }
	}


	public class ProcessOrderCommandHandler
	{
		public void Process(ProcessOrderCommand command)
		{
			var validationResult = Validate(command);

			foreach (var itemId in validationResult.ItemIds)
			{
				// do something with each item
			}

			UpdateCarrier(validationResult.Carrier);
		}

		private void UpdateCarrier(object carrier)
		{
			// no logic for example purpose
		}

		private ValidationResult Validate(ProcessOrderCommand command)
		{
			// hard-code return values for example purposes
			var carrier = new { Name = "DHL" };
			var itemIds = new[] { Guid.NewGuid() };


			return new ValidationResult
			{
				Carrier = carrier,
				ItemIds = itemIds,
			};
		}

		private class ValidationResult
		{
			public object Carrier { get; set; }
			public Guid[]? ItemIds { get; set; }
		}
	}
}
