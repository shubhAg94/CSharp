using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DisposePattern
{
    public class WithDispose : IDisposable
    {
        private Stopwatch stopwatch = null;
        private bool disposed = false;

        public WithDispose()
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                stopwatch.Stop();
                Interlocked.Increment(ref Program.finalisedObjects);
                Interlocked.Add(ref Program.totalTime, stopwatch.ElapsedMilliseconds);

                if(disposing)
                {
                    //explixitly called from user code
                    //you can do basically anything here
                }
                else
                {
                    // called from finaliser
                    //do not access reference, run quickly etc
                }

                disposed = true;
            }
        }

        ~WithDispose()
        {
            Dispose(false);
        }
    }
}
