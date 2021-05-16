using System;

//https://www.codeproject.com/Articles/874246/Understanding-and-Implementing-Factory-Pattern-i
namespace FactoryPattern2
{
    //It is almost impossible to have an application that contains only one class. Typically an application will have 
    //many classes involved, each with a dedicated responsibility, to implement the desired functionality. 
    //Which would mean that it is inevitable for the classes to communicate with other classes.

    // B b = new B(); in A class constructor, 
    //This approach of having the class instances contained inside other classes will work but it has some downsides. 
    //The first problem is that each class needs to know about every other class that it wants to use. This will make this application a maintenence nightmare. 
    //Also, the above approach will increase the coupling between the classes.

    //This is exactly where the Factory pattern will be useful. The Factory completely hides the process of creating objects.
    //Factory pattern totally abstract our the responsibility of creating classes from the client classes. 
    //The major benefit of this is that our client code is completely ignorant of creation process of dependent classes.

    //This loose coupling also good from the extensibility perspective.

    class Program
    {
        static void Main(string[] args)
        {
            //PaymentProcessor pp = new PaymentProcessor();
            //pp.MakePayment(PaymentMethod.BEST_FOR_ME, new Product() { Name = "Product 1", Price = 30 });

            PaymentProcessor2 pp2 = new PaymentProcessor2();
            pp2.MakePayment(PaymentMethod.BEST_FOR_ME, new Product() { Name = "Product 1", Price = 30 });

            Console.ReadKey();
        }
    }
}
