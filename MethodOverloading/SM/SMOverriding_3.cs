using System;

namespace SM
{
    class Base3
    {
        public virtual void M1(int a)
        {
            Console.WriteLine($"Base3 {a}");
        }
    }

    class C1 : Base3
    {
        public new void M1(int a)
        {
            Console.WriteLine($"C1 {a}");
        }
    }

    class C2: C1
    {
        public new void M1(int a)
        {
            Console.WriteLine($"C1 {a}");
        }
    }
}
