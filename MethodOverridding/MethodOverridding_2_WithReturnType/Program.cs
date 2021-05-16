using System;

namespace MethodOverridding_2_WithReturnType
{
    class P
    {
        public virtual Object m1()
        {
            Console.WriteLine("Parent Method with Object return type");
            return null;
        }
    }

    class C : P
    {
        //Acces modifier should be same for method overridding 
        //public override string m1()//Return type must be 'Object to match with parent method'
        //{
        //    Console.WriteLine("Child Method with string return type");
        //    return null;
        //}

        public override object m1()
        {
            Console.WriteLine("Child Method with Object return type");
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
        }
    }
}
