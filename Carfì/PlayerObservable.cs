namespace PowPaw
{
    public class PlayerObservable : IPlayerObservable
    {
        private readonly List<Player> _playerList;
        private readonly KeyObservable _observable = new KeyObservable();

        /**
         * Constructor of the class. Initializes the list of players, the configuration
         * file parser and sets the attack controller and key observers for each player.
         * 
         * @param playerList the list of players to be kept track of.
         */
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