namespace PowerUpAndStats
{
    public interface IPowerUp
    {

        bool Visible { get; set; }

        void StatPowerUp(PlayerStats stats);
    }
}
