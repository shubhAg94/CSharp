using System;

namespace GenericsImplementation
{
    class NonGenericClass
    {
        public void Test<T> (T item)
        {
            Console.WriteLine($"{item} => Generic method in non generic class");
        }
    }
}
