using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Extension_Methods.After
{
    public static class IntExtensions
    {
        public static bool IsEven(this int input) =>
            input % 2 == 0;
    }
}
