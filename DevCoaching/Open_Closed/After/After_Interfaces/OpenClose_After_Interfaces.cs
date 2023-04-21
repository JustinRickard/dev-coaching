using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Open_Closed.After.After_Interfaces
{
    public interface IChargeOperator
    {
        decimal CalculateCharge(decimal initialValue, decimal newValue, bool isLateAddition);
    }


    public class ChargeCalculatorWithInterfaces
    {
        private readonly IChargeOperatorFactory _operatorFactory;

        public ChargeCalculatorWithInterfaces(IChargeOperatorFactory operatorFactory)
        {
            _operatorFactory = operatorFactory;
        }

        // Pass in type
        public decimal CalculateCharge(OperatorType type, decimal initialValue, decimal newValue, bool isLateAddition)
        {
            return _operatorFactory.Create(type).CalculateCharge(initialValue, newValue, isLateAddition);
        }

        // Pass in operator class
        public decimal CalculateCharge(IChargeOperator chargeOperator, decimal initialValue, decimal newValue, bool isLateAddition)
        {
            return chargeOperator.CalculateCharge(initialValue, newValue, isLateAddition);
        }
    }
}
