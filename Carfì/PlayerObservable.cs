namespace PowPaw
{
    public class PlayerObservable : IPlayerObservable
    {
        private readonly List<Player> _playerList;
        private readonly KeyObservable _observable = new();

        public PlayerObservable(List<Player> playerList)
        {
            _playerList = playerList;
            _playerList.ForEach(
                    player => _observable.AddObserver(new KeyObserver(player)));
        }

        public List<Player> Players => _playerList;

        public KeyObservable KeyObservable => _observable;

        public void Update()
        {
            _playerList.ForEach(player => player.Update());
        }
    }
}