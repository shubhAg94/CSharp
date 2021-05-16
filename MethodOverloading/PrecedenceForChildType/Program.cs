using System;
using System.Text;

namespace PrecedenceForChildType
{
    class Program
    {
        public void m1(string s)
        {
            Console.WriteLine("string version");
        }

        public void m1(object o)
        {
            Console.WriteLine("object version");
        }

        public void m1(StringBuilder sb)
        {
            Console.WriteLine("StringBuilder version");
        }

        public void m2(int i, float f)
        {
            Console.WriteLine("int-float");
        }

        public void m2(float f, int i)
        {
            Console.WriteLine("float-int");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.m1("Shubham");
            p.m1(new Object());
            //p.m1(null);

            p.m2(10, 10.5f);
            p.m2(10.5f, 10);

            //p.m2(10, 10);//Ambiguity
            //p.m2(10.5f, 10.5f);//Ambiguity

            Console.ReadKey();
        }
    }
}
