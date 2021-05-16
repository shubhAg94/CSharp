using System;

namespace SingletonDP
{
    //Singleton pattern falls under Creational Pattern of Gang of Four (GOF) Design Patterns in .Net
    //This pattern ensures that a class has only one instance.
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.WriteLine(fromStudent.GetHashCode());

            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
            Console.WriteLine(fromStudent.GetHashCode());

            Console.WriteLine("-------------------------------------");

            Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
            derivedObj.PrintDetails("From Derived");
            Console.WriteLine(fromStudent.GetHashCode());

            Console.ReadLine();
        }
    }
}
