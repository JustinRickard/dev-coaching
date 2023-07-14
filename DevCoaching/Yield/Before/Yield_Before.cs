using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Yield.Before
{
    public class Yield_Before
    {

        public IEnumerable<int> GetNumbers()
        {
            var result = new List<int>();

            foreach (var number in Enumerable.Range(1, 10))
            {
                result.Add(number);
            }

            return result;
        }
    }
}
