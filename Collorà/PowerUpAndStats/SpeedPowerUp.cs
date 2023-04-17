using System.Threading.Tasks;

namespace PowerUpAndStats
{
    public class SpeedPowerUp : PowerUp
    {
        public override async void StatPowerUp(PlayerStats stats)
        {
            double oldSpeed = stats.Speed;
            stats.Speed=oldSpeed + s_powNumber;
            await Task.Delay(7000);
            stats.Speed = oldSpeed;
        }
    }
}