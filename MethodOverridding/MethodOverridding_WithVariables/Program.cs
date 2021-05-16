using System;

namespace MethodOverridding_WithVariables
{
    class P
    {
        public int x = 888;//We can not use virtual with variables
    }

    class C : P
    {
        public new int x = 999;//It is hiding the 'P.x', so used new keyword
    }

    class Program
    {
        static void Main(string[] args)
        {
            P p = new P();
            Console.WriteLine(p.x);//888 results will be same wether it is static or non static because we are hiding parent class variable

            C c = new C();
            Console.WriteLine(c.x);//999

            P p1 = new C();
            Console.WriteLine(p1.x);//888

            Console.ReadKey();

        }
    }
}
