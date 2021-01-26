using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObserver
    {
        //Receive update from a subject
        void Update(ISubject subject);
    }
}
