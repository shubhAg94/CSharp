using System;

namespace IteratorPattern
{
    //IEnumerable and IEnumerator are implementation of the iterator pattern in.
    //This means you can use a foreach block to iterate over that type.

    //In C#, all collections (list,dictionarie,stack,queue,etc) are enumerable because they implement the IEnumerable interface. 
    //So are strings. You can iterate over a string using a foreach block to get every character in the string.

    //It provides a mechanism to traverse an object irrespective of how it is internally represented.
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine("Accessed by indexer\n");
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);

            Console.WriteLine("By foreach loop");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nBy ienumerator");
            var ienumerator = list.GetEnumerator();
            while (ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current);
            }

            //MyGenericList<int> list = new MyGenericList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //Console.WriteLine("Accessed by indexer\n");
            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list[2]);

            //Console.WriteLine("By foreach loop");
            //foreach (var item in list)
            //{
            //    if (item == 0)
            //        return;
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
    }
}
