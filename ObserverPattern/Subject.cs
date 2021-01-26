using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ObserverPattern
{
    // The Subject owns some important state and notifies observers when the
    // state changes
    public class Subject : ISubject
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable
        public int State { get; set; } = -0;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        public List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("From Subject: Attached an observer");
            _observers.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("From subject: Detached an observer");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("From subject: Notiying observer....");
            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void SomeBusinessLogic()
        {
            Console.WriteLine("From Subject: I am doing something important, will notify once done.");
            this.State = new Random().Next(0, 10);
            Thread.Sleep(10);
            Console.WriteLine($"From Subject: My State has just changed to {this.State}");
            this.Notify();
        }
    }
}
