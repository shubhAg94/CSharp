using System;

namespace SM
{
    public class A
    {
        public A()
        {
            Console.WriteLine("A");
        }

        static A()
        {
            Console.WriteLine("Static A");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }

        static B()
        {
            Console.WriteLine("Static B");
        }
    }

    public class C : B
    {
        public C()
        {
            Console.WriteLine("C");
        }

        static C()
        {
            Console.WriteLine("Static C");
        }

        public void Display()
        {
            Console.WriteLine("Display C");
        }
    }

    public class Base
    {
        public virtual void M1()
        {
            Console.WriteLine("BASE M1");
        }
    }

    public class Derived1 : Base
    {
        public override void M1()
        {
            Console.WriteLine("Derived1 M1");
        }
    }

    public class Derived2 : Derived1
    {
        public override void M1()
        {
            Console.WriteLine("Derived2 M1");
        }
    }
}
