using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class DogFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            //Creating a Dog
            return new Dog();
        }
    }
}
