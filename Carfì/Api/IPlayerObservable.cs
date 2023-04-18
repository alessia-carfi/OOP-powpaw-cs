namespace PowPaw
{
    public interface IPlayerObservable
    {
        List<Player> Players { get; }
        KeyObservable KeyObservable { get; }
        void Update();
    }
}