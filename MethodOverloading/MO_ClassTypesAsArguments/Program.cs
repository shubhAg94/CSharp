using System;

namespace MO_ClassTypesAsArguments
{
    class Animal
    {

    }

    class Monkey : Animal
    {

    }

    class Program
    {
        public void m1(Animal a)
        {
            Console.WriteLine("Animal version");
        }

        public void m1(Monkey m)
        {
            Console.WriteLine("Monkey version");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Animal a = new Animal();
            p.m1(a);

            Monkey m = new Monkey();
            p.m1(m);

            Animal a1 = new Monkey();
            p.m1(a1);

            Console.ReadKey();
        }
    }
}
