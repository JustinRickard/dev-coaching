using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Open_Closed.After.After_Interfaces
{
    public interface IChargeOperatorFactory
    {
        IChargeOperator Create(OperatorType type);
    }

    public class ChargeOperatorFactory
    {
        public IChargeOperator Create(OperatorType type)
        {
            switch (type)
            {
                case OperatorType.Add:
                    return new AddOperator();
                case OperatorType.Subtract:
                    return new SubtractOperator();
                default: throw new Exception("Invalid Operator Type");
            }
        }
    }
}
