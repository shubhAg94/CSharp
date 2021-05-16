namespace ObserverDP
{
    public interface IPublisher
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify();
    }
}
