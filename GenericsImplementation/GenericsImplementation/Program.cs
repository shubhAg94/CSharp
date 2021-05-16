using System;

namespace GenericsImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> obj = new GenericClass<string>();
            string val = obj.GenericMethod("200");

            //obj.Test();
            //obj.Test1(10);

            //NonGenericClass ng = new NonGenericClass();
            //ng.Test(10);

            Console.ReadKey();
        }
    }
}
