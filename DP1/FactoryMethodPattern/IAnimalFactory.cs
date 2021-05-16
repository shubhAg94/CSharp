using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class IAnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("\n IAnimalFactory.MakeAnimal()-You cannot ignore parent rules.");
            //At this point, it doesn't know whether it will get a Dog or a Tiger. It will be decided by the subclasses 
            //i.e.DogFactory or TigerFactory. But it knows that it will Speak and it will have a preferred way of Action.

            //In commented code(Earlier implementation) below four lines was part of Main method
            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();
            return animal;
        }

        //So, the following method is acting like a factory  
        //(of creation).
        public abstract IAnimal CreateAnimal();
    }

    //public interface IAnimalFactory
    //{
    //    //Remember the GoF definition which says "....Factory method lets a class 
    //    //defer instantiation to subclasses." Following method will create a Tiger  
    //    //or Dog But at this point it does not know whether it will get a Dog or a  
    //    //Tiger. It will be decided by the subclasses i.e.DogFactory or TigerFactory.  
    //    //So, the following method is acting like a factory (of creation).
    //    IAnimal CreateAnimal();
    //}
}
