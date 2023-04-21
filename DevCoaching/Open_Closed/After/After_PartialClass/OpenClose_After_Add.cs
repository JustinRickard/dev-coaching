using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Open_Closed.After
{
    public partial class ChargeCalculator
    {
        public decimal CalculateAddCharge(decimal initialValue, decimal newValue, bool isLateAddition)
        {
            var result = initialValue + newValue;

            if (isLateAddition)
            {
                result *= 1.1M; // Add 10% admin charge for adding something on
            }

            return result;
        }
    }
}
