using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class WildTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Wild Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Wild Tigers prefer hunting in jungles.\n");
        }
    }
}
