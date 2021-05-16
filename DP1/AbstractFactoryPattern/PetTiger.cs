using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class PetTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Pet Tigers play in an animal circus.\n");
        }
    }
}
