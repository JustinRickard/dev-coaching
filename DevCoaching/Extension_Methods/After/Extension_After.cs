using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Extension_Methods.After
{
    public class Extension_After
    {
        public int GetHalfQuantity(int input)
        {
            return input.IsEven()
                ? input / 2
                : (input / 2) + 1;

        }
    }
}
