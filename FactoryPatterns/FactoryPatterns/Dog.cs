using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-Wow.");
        }
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...");
        }
    }
}
