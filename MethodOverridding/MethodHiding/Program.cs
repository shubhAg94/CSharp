using System;

namespace MethodHiding
{
    class P
    {
        public virtual void M1()
        {
            Console.WriteLine("Parent M1 Method");
        }

        public void M2()
        {
            Console.WriteLine("Parent M2 Method");
        }
    }

    class C : P
    {
        public new void M1()
        {
            Console.WriteLine("Child M1 Method");
        }

        public new void M2()
        {
            Console.WriteLine("Child M2 Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            P p = new P();
            p.M1();
            p.M2();

            C c = new C();
            c.M1();
            c.M2();

            P p1 = new C();
            p1.M1();//Parent M1() will be called because in method hiding method resolution happens based on reference type 
            p1.M2();//Parent M2() will be called because in method hiding method resolution happens based on reference type

            Console.ReadKey();
        }
    }
}
