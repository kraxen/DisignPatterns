namespace BehaviorPatterns.Observer.Example1
{
    public interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
