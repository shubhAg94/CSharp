using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public interface ISimpleFactory
    {
        IAnimal CreateAnimal();
    }
}
