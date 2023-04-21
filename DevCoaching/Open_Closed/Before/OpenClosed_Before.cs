using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Open_Closed.Before
{
    public class ChargeCalculator
    {
        public decimal CalculateCharge(OperatorType type, decimal initialValue, decimal newValue, bool isLateAddition)
        {
            decimal result;
            switch (type)
            {
                case OperatorType.Add:
                    result = initialValue + newValue;
                    break;
                case OperatorType.Subtract:
                    result = initialValue - newValue;
                    break;
                default: throw new Exception("Invalid operator");

            }

            if (type == OperatorType.Add && isLateAddition)
            {
                result *= 1.1M; // Add 10% admin charge for adding something on
            }

            return result;
        }
    }

    public enum OperatorType
    {
        Add,
        Subtract,
    }
}
