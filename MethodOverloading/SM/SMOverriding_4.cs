using System;
using System.Collections.Generic;
using System.Text;

namespace SM
{
    class Base4
    {
        public virtual void M1(int a)
        {
            Console.WriteLine($"Base3 {a}");
        }
    }

    class CC1 : Base4
    {
        public override void M1(int a)
        {
            Console.WriteLine($"C1 {a}");
        }

        public void M1(int a, double b= 5)
        {
            Console.WriteLine($"C1 {a}");
        }
    }

    class CC2 : CC1
    {
        public new void M1(int a)
        {
            Console.WriteLine($"C1 {a}");
        }
    }
}
