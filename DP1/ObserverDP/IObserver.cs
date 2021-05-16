using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP
{
    public interface IObserver
    {
        void Update(string productName);
    }
}
