using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemyParallelProgramming
{
    class ExceptionHandling
    {
        public static void BasicHandling()
        {
            var t = Task.Factory.StartNew(() =>
            {
                throw new InvalidOperationException("Can't do this!") { Source = "t" };
            });

            var t2 = Task.Factory.StartNew(() =>
            {
                var e = new AccessViolationException("Can't access this!");
                e.Source = "t2";
                throw e;
            });

            try
            {
                Task.WaitAll(t, t2);
            }
            catch (AggregateException ae)
            {
                foreach (Exception e in ae.InnerExceptions)
                {
                    Console.WriteLine($"Exception {e.GetType()} from {e.Source}.");
                }
            }
        }

        static void Main()
        {
            //BasicHandling();

            try
            {
                IterativeHandling();
            }
            catch (AggregateException ae) // Exceptions other than InvalidOperationException will be handled here.
            {
                Console.WriteLine("Some exceptions we didn't expect:");
                foreach (var e in ae.InnerExceptions)
                    Console.WriteLine($" - {e.GetType()}");
            }
        }

        private static void IterativeHandling()
        {
            var t1 = Task.Factory.StartNew(() =>
            {
                throw new InvalidOperationException("Can't do this!") { Source = "t" };
            });

            var t2 = Task.Factory.StartNew(() =>
            {
                var e = new AccessViolationException("Can't access this!");
                e.Source = "t2";
                throw e;
            });

            try
            {
                Task.WaitAll(t1, t2);
            }
            catch (AggregateException ae)
            {
                // handle exceptions depending on whether they were expected or
                // handles all expected exceptions ('return true'), throws the
                // unhandled ones back as an AggregateException
                ae.Handle(e =>
                {
                    if (e is InvalidOperationException)
                    {
                        Console.WriteLine("Invalid op!");
                        return true; // InvalidOperationException was handled
                    }
                    else
                    {
                        Console.WriteLine($"Something went wrong: {e}");
                        return false; // other exception was NOT handled
                    }
                });
            }
        }
    }
}
