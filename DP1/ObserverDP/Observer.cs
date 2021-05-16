using System;

namespace ObserverDP
{
    public class Observer : IObserver
    {
        public string ObserverName { get; set; }

        public Observer(string name)
        {
            ObserverName = name;
        }

        public void Update(string productName)
        {
            Console.WriteLine($"{productName}: A new product has arrived at the {this.ObserverName} store");
        }
    }
}
