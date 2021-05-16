using System;

namespace var_args
{
    class Program
    {
        public void m1(int x)
        {
            Console.WriteLine("General Method");
        }

        public void m1(params int[] x)
        {
            Console.WriteLine("var-arg-params method");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.m1();
            p.m1(10, 20);
            p.m1(10);//var-arg method gets least priority

            Console.ReadKey();
        }
    }
}
