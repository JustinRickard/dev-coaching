using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Tuples.After_ValueTuple
{
    public class ProcessOrderCommand
    {
        public Guid OrderId { get; set; }
    }


    public class ProcessOrderCommandHandler
    {
        public void Process(ProcessOrderCommand command)
        {
            var (carrier, itemIds) = Validate(command);

            foreach (var itemId in itemIds)
            {
                // do something with each item
            }

            UpdateCarrier(carrier);
        }

        private void UpdateCarrier(object carrier)
        {
            // no logic for example purpose
        }

        private ValueTuple<object, Guid[]> Validate(ProcessOrderCommand command)
        {
            // hard-code return values for example purposes
            var carrier = new { Name = "DHL" };
            var itemIds = new[] { Guid.NewGuid() };


            return ((object)carrier, itemIds);
        }
    }
}
