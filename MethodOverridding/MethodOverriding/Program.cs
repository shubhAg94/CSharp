using System;

namespace MethodOverriding
{
    class P
    {
        public virtual void m1()
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

    class Program
    {
        static void Main(string[] args)
        {
            P p = new P();
            p.m1();//Parent Method

            C c = new C();
            c.m1();//Child Method

            P p1 = new C();
            p1.m1();//Child Method because in overridding method resolution always takes care by JVM(In case of JAVA) based on Runtime Object.


            P1 obj = new C1();
            obj.M1();

            Console.ReadKey();
        }
    }

    class P1
    {
        public virtual void M1()
        {
            Console.WriteLine("P1 Parent Method M1");
        }
    }

    class C1 : P1
    {

    }
}
