using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Open_Closed.After.After_Interfaces
{
    public class SubtractOperator : IChargeOperator
    {
        public decimal CalculateCharge(decimal initialValue, decimal newValue, bool isLateAddition)
        {
            var result = initialValue - newValue;
            if (isLateAddition) result *= 1.05M; // Add 5% admin charge for adding something on

            return result;
        }
    }
}
