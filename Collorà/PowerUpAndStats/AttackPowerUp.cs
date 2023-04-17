namespace PowerUpAndStats
{
    public class AttackPowerUp : PowerUp
    {
        public override async void StatPowerUp(PlayerStats stats)
        {
            double oldAttack = stats.Attack;
            stats.Attack = oldAttack + s_powNumber;
            await Task.Delay(7000);
            stats.Attack = oldAttack;
        }
    }
}