﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Tigers prefer hunting...");
        }
    }
}
