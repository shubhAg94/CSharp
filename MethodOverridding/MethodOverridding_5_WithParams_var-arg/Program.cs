using System;

namespace MethodOverridding_5_WithParams_var_arg
{
    class Program
    {
        class P
        {
            public virtual void M1(params int[] x)
            {
                Console.WriteLine("Parent M1 Method");
            }

            public virtual void M2(params int[] x)
            {
                Console.WriteLine("Parent M2 Method");
            }

            public virtual void M3(int x)
            {
                Console.WriteLine("Parent M3 Method");
            }
        }

        class C : P
        {
            /// <summary>
            /// We can override vararg method with another vararg method only.
            /// </summary>
            public override void M1(params int[] x)
            {
                Console.WriteLine("Child M1 Method");
            }

            /// <summary>
            /// We can not override vararg method as normal method.
            /// </summary>
            //public override void M2(int x)
            //{
            //    Console.WriteLine("Child M2 Method");
            //}

            /// <summary>
            /// Here we are neither overridding Parent M2 method nor hiding, It is a separate method in child class.
            /// </summary>
            public void M2(int x)
            {
                Console.WriteLine("Child M2 Method");
            }

            //public override void M3(params int[] x)//We can not override a normal method as var arg method.
            //{
            //    Console.WriteLine("Parent M3 Method");
            //}
        }

        static void Main(string[] args)
        {
            P p = new P();
            p.M2(10);

            C c = new C();
            c.M2();

            P p1 = new C();
            p1.M2();

            Console.ReadKey();
        }
    }
}
