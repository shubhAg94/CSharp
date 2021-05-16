using System;

namespace MethodOverriding_4_WithAbstractMethods
{
    class Program
    {
        abstract class P
        {
            public abstract void M1();

            public virtual void M2()
            {
                Console.WriteLine("M2 Parent Method");
            }
        }

        class C : P
        {
            /// <summary>
            /// We can override a abstract method to provide its compulsory implementation in inherited class
            /// </summary>
            public override void M1()
            {
                Console.WriteLine("M1 Child Method");
            }
        }

        abstract class CC : P
        {
            public override void M1()
            {
                Console.WriteLine("M1 Child Method");
            }

            /// <summary>
            /// We can override a concrete method as abstarct method, So we can stop the 
            /// availability of parent method implementation to the next level child class
            /// </summary>
            public override abstract void M2();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
