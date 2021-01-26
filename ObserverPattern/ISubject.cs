namespace ObserverPattern
{
    public interface ISubject
    {
        // Attach an observer from the subject.
        void Attach(IObserver observer);
        // Detach an observer from the subject.
        void Dettach(IObserver observer);
        // Notify all observers about an event.
        void Notify();
    }
}