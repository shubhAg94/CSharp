using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    interface ISimpleFactory
    {
        IAnimal CreateAnimal();
    }
}
