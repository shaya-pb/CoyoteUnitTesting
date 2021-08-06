using System;
using System.Threading.Tasks;

namespace CoyoteUnitTesting
{
    public class Class1
    {
        public int Counter { get; set; }

        public async Task UpdateCounter(int i)
        {
            var rand = new Random();
            await Task.Delay((int) (1000 * rand.NextDouble()));
            await Task.Run(() => Counter = i);
        }
    }
}
