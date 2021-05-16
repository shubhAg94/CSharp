using System;

namespace AutomaticPromotion
{
    class Program
    {
        void m1(int i)
        {
            Console.WriteLine("int-arg");
        }

        void m1(float f)
        {
            Console.WriteLine("float-arg");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.m1(10);
            p.m1(10.5f);
            p.m1('a');
            p.m1(10L);
            //p.m1(10.5); //Cannot convert double from int 

            Console.ReadKey();
        }
    }
}
