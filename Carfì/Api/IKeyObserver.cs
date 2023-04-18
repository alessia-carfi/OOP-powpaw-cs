namespace PowPaw
{
    public interface IKeyObserver
    {
        void KeyPressed(ConsoleKey e);

        void KeyReleased(ConsoleKey e);
    }
}