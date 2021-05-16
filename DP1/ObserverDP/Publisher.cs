using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP
{
    public class Publisher : IPublisher
    {
        private List<IObserver> observers = new List<IObserver>();
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                Notify();

            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this.ProductName);
            }
        }
    }
}
