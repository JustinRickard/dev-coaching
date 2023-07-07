using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Tuples.After_Tuple
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

            var carrier = validationResult.Item1;
            var itemids = validationResult.Item2;

            foreach (var itemId in itemids)
            {
                // do something with each item
            }

            UpdateCarrier(carrier);
        }

        private void UpdateCarrier(object carrier)
        {
            // no logic for example purpose
        }

        private Tuple<object, Guid[]> Validate(ProcessOrderCommand command)
        {
            // hard-code return values for example purposes
            var carrier = new { Name = "DHL" };
            var itemIds = new[] { Guid.NewGuid() };


            return Tuple.Create((object)carrier, itemIds);
        }
    }

}
