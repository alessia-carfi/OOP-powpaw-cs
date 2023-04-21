namespace PowPaw
{
    public class KeyObservable : IKeyObservable
    {
        private readonly List<KeyObserver> _observers = new();

        public void AddObserver(KeyObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(KeyObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserversPressed(ConsoleKey e)
        {
            _observers.ForEach(obs => obs.KeyPressed(e));
        }

        public void NotifyObserversReleased(ConsoleKey e)
        {
            _observers.ForEach(obs => obs.KeyReleased(e));
        }
    }
}