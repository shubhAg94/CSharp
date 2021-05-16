using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
