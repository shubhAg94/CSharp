using System;
using System.Threading;

namespace Finalizers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            while (!Console.KeyAvailable)
            {
                new MyObject(count++);
            }
            Console.WriteLine("Terminating process...");
        }
    }

    public class MyObject
    {
        private int _index = 0;
        public MyObject(int index)
        {
            this._index = index;
            Console.WriteLine("Constructed object {0} in gen {1}", _index, GC.GetGeneration(this));
        }

        ~MyObject()
        {
            Thread.Sleep(500);
            Console.WriteLine("Finalized object {0} in gen {1}", _index, GC.GetGeneration(this));
        }
    }
}
