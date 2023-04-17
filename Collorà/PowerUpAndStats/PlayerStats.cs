namespace PowerUpAndStats
{
    public class PlayerStats : IPlayerStats
    {
        private double _attack;
        private double _defence;
        private double _speed;

        public PlayerStats(in double attack, in double defence, in double speed)
        {
            _attack = attack;
            _defence = defence;
            _speed = speed;
        }

        public double Attack { get => _attack; set => _attack=value ; }
        public double Defence { get => _defence; set => _defence=value; }
        public double Speed { get => _speed; set => _speed = value; }
    }
}
