using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DisposePattern
{
    class WithoutDispose
    {
        private Stopwatch stopwatch = null;
        public WithoutDispose()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public void DoWork()
        {
            //some simulation
            double j = 0;
            for (int i = 0; i < 1000; i++)
            {
                j += i * i;
            }
        }

        ~WithoutDispose()
        {
            stopwatch.Stop();
            Interlocked.Increment(ref Program.finalisedObjects);
            Interlocked.Add(ref Program.totalTime, stopwatch.ElapsedMilliseconds);
        }
    }
}
