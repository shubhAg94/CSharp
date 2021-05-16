using System;

namespace MethodOverriding_WithStatic
{
    class Program
    {
        class P
        {
            //public static virtual void m1()//A static method can not be marked as virtual, abstract and override
            //{
            //    Console.WriteLine("Parent Method");
            //}

            //public static abstract void m2();//A static method can not be marked as abstarct

            //public virtual void M3()
            //{
            //    Console.WriteLine("Parent M3 Method");
            //}

            public static void M4()
            {
                Console.WriteLine("Parent M4 Method");
            }
        }

        class C : P
        {
            //public static override void M3()////A static method can not be marked as virtual, abstract and override
            //{
            //    Console.WriteLine("Child Method");
            //}

            public new static void M4()//Method hiding is possible for static methods.
            {
                Console.WriteLine("Child M4 Method");
            }

            /// <summary>
            /// Method overloading is possible for static methods.
            /// </summary>
            public static void M4(int item)
            {
                Console.WriteLine("Child M4 Method");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
