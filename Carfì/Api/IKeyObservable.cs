namespace PowPaw
{
    public interface IKeyObservable
    {
        void AddObserver(KeyObserver observer);
        void RemoveObserver(KeyObserver observer);
        void NotifyObserversPressed(ConsoleKey e);
        void NotifyObserversReleased(ConsoleKey e);
    }
}