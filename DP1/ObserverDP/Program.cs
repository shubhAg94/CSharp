using System;

namespace ObserverDP
{
    //It is a Behavioral Design Pattern : These patterns deal with the process of communication, managing relationships, 
    //and responsibilities between objects.

    //Pub-Sub (Publisher-Subscriber) is yet another popular nickname given to Observer pattern.
    //"Define a one-to-many dependency between objects so that when one object changes state,..
    //..all its dependents are notified and updated automatically."

    //The Observer pattern is to notify the interested observers about some change occurred. 
    //We can add more observers in runtime as well as remove them.

    //This pattern is allows a single object, known as the subject, 
    //to publish changes to its state and other observer objects that 
    //depend upon the subject are automatically notified of any changes to the subject's state.
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            IObserver observer1 = new Observer("Observer 1");

            // Observer1 takes a subscription to the store
            publisher.Subscribe(observer1);
            // Observer2 also subscribes to the store
            publisher.Subscribe(new Observer("Observer 2"));

            publisher.ProductName = "Item 1";

            // Observer1 unsubscribes and Observer3 subscribes to notifications.
            publisher.Unsubscribe(observer1);
            publisher.Subscribe(new Observer("Observer 3"));
            publisher.ProductName = "Item 2";

            Console.ReadKey();

        }
    }
}
