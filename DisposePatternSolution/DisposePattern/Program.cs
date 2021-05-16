using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposePattern
{
    class Program
    {
        public static long finalisedObjects = 0;
        public static long totalTime = 0;
        static void Main(string[] args)
        {
            //for (int i = 0; i < 500000; i++)
            //{
            //    var obj = new WithoutDispose();
            //    obj.DoWork();
            //}

            for (int i = 0; i < 500000; i++)
            {
                using (var obj = new WithDispose())
                {
                    obj.DoWork();
                }
            }

            double avgLifeTime = 1.0 * totalTime / finalisedObjects;
            Console.WriteLine("Number of disposed/finalised objects: {0}k", finalisedObjects/1000);
            Console.WriteLine("Average resorce lifetime {0}ms", avgLifeTime);

            Console.ReadKey();
        }
    }
}
