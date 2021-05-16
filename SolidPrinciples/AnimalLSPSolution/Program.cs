using System;

namespace AnimalLSPSolution
{
    /*https://csharp-video-tutorials.blogspot.com/2018/01/open-closed-principle.html
     * https://www.dotnetcurry.com/software-gardening/1235/liskov-substitution-principle-lsp-solid-patterns
      
    Subtypes must be substitutable for their base type.
    LSP States that IS-A relationship is insufficient and should be replaced with IS-Substitutable with
    IS-Substitutable-For

    If S is a subtype of T then objects of type T may be replaced with objects of type S, without breaking
    the program.
    -->Which means, Derived types must be completely substitutable for their base types
    -->This principle is just an extension of the Open Close Principle

    More formally, the Liskov substitution principle (LSP) is a particular definition of a subtyping relation, 
    called (strong) behavioral subtyping.

    Uncle Bob summarized LSP as “Subtypes must be substitutable for their base types”. In other words, 
    given a specific base class, any class that inherits from it, can be a substitute for the base class.
    
    Implementation guidelines : In the process of development we should ensure that 
    1.No new exceptions can be thrown by the subtype unless they are part of the existing exception hierarchy.
    2.We should also ensure that Clients should not know which specific subtype they are calling, nor should they 
    need to know that. The client should behave the same regardless of the subtype instance that it is given.
    3.And New derived classes just extend without replacing the functionality of old classes

    Violation of LSP:
    The classic example of this shows how you cannot substitute a rectangle class for a square class.
    Means if a square class inherits the Rectangle class it is a voilation.

     */
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            Console.WriteLine(animal.Walk());
            Console.WriteLine(animal.Run());
            Console.WriteLine(animal.Fly());
            Console.WriteLine(animal.MakeNoise());
            Console.ReadLine();

            /*
             If you run this code for Dog, you get the following output.

            Move feet
            Move feet quickly
 
            Bark
            Note the blank line for Fly( ). Dogs don’t fly, so nothing gets returned. Now change Dog to Bird and you get

            Move feet
            Move feet quickly
            Flag wings
            Bark
            What happens if you now change Bird to Animal?

            Move feet
            Move feet quickly
            A subclass (Dog or Bird) can be substituted for the base class (Animal) and everything still works. 
            The code itself doesn’t care. We could also take this one step further and use a Factory method to create
            the class we want to use, and the code wouldn’t even know the class at all. But that’s beyond this discussion
             */
        }
    }

    public class Animal
    {
        public string Walk()
        {
            return "Move feet";
        }

        public string Run()
        {
            return "Move feet quickly";
        }

        public virtual string Fly()
        {
            return null;
        }

        public virtual string MakeNoise()
        {
            return null;
        }
    }

    public class Dog : Animal
    {
        public override string MakeNoise()
        {
            return "Bark";
        }
    }

    public class Bird : Animal
    {
        public override string MakeNoise()
        {
            return "Chirp";
        }

        public override string Fly()
        {
            return "Flag wings";
        }
    }
}
