using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Earlier implementation of IAnimalFactory
            //Console.WriteLine("***Factory Pattern Demo***\n");

            //// Creating a Tiger Factory
            //IAnimalFactory tigerFactory = new TigerFactory();
            //// Creating a tiger using the Factory Method
            //IAnimal aTiger = tigerFactory.CreateAnimal();
            //aTiger.Speak();
            //aTiger.Action();

            //// Creating a DogFactory
            //IAnimalFactory dogFactory = new DogFactory();
            //// Creating a dog using the Factory Method
            //IAnimal aDog = dogFactory.CreateAnimal();
            //aDog.Speak();
            //aDog.Action();

            //Foe New implementation of IAnimalFactory
            Console.WriteLine("***Beautification to Factory Pattern Demo * **\n");

            // Creating a tiger  using the Factory Method
            IAnimalFactory tigerFactory = new TigerFactory();
            IAnimal aTiger = tigerFactory.MakeAnimal();

            // Creating a dog using the Factory Method
            IAnimalFactory dogFactory = new DogFactory();
            IAnimal aDog = dogFactory.MakeAnimal();

            Console.ReadKey();
        }
    }
}
