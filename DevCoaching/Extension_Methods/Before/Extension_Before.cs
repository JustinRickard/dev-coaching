using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Extension_Methods.Before
{
    public class Extension_Before
    {
        public int GetHalfQuantity(int input)
        {
            return IsEven(input)
                ? input / 2
                : (input / 2) + 1;

        }

        public bool IsEven(int input) =>
            input % 2 == 0;
    }
}
