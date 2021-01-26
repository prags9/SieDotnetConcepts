using System;

namespace ObserverPattern
{
    //The client code
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.Dettach(observerB);
            subject.SomeBusinessLogic();
        }
    }
}
