using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class PetDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Pet Dog says: Bow-Wow.");
        }
        public void Action()
        {
            Console.WriteLine("Pet Dogs prefer to stay at home.\n");
        }
    }
}
