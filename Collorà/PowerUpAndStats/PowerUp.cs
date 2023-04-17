namespace PowerUpAndStats
{
    public abstract class PowerUp : IPowerUp
    {
        protected static readonly double s_powNumber = 2;
        protected static readonly double s_powDuration = 7;
        private bool _visible = true;

        public bool Visible { get => _visible; set => _visible = value; }

        public abstract void StatPowerUp(PlayerStats stats);
    }
}