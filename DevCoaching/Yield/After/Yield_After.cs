using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Yield.After
{
    public class Yield_After
    {
        public IEnumerable<int> GetNumbers()
        {
            foreach (var number in Enumerable.Range(1, 10))
            {
                yield return number;
            }
        }

        public async IAsyncEnumerable<int> GetNumbersAsync()
        {
            foreach (var number in Enumerable.Range(1, 10))
            {
                yield return await GetIntAsync();
            }
        }

        public async Task<int> GetIntAsync() => await Task.FromResult(7);
    }
}
