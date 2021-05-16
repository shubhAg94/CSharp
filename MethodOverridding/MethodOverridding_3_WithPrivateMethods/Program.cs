using System;

namespace MethodOverridding_3_WithPrivateMethods
{
    class Program
    {
        class P
        {
            private virtual void m1()//virtual or abstract methods cannot be private means we cannot override private methods.
            {
                Console.WriteLine("Parent Method");
            }
        }

        class C : P
        {
            public override void m1()
            {
                Console.WriteLine("Child Method");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
