using Xunit;

namespace PowerUpAndStats;

public class PowerUpTest
{
    [Fact]
    public static async Task AttackPowerUpTest()
    {
        PlayerStats stats = new PlayerStats(4, 5, 6);
        PowerUp powup = new AttackPowerUp();
        double expectedValue = stats.Attack + 2;
        double oldvalue = stats.Attack;
        powup.StatPowerUp(stats);
        Assert.Equal(expectedValue, stats.Attack);
        await Task.Delay(8000); //additional second added because the task is not completed always in 7000 ms
        Assert.Equal(oldvalue, stats.Attack);
    }

    [Fact]
    public static async Task SpeedPowerUpTest()
    {
        PlayerStats stats = new PlayerStats(4, 5, 6);
        PowerUp powup = new SpeedPowerUp();
        double expectedValue = stats.Speed + 2;
        double oldvalue = stats.Speed;
        powup.StatPowerUp(stats);
        Assert.Equal(expectedValue, stats.Speed);
        await Task.Delay(8000);
        Assert.Equal(oldvalue, stats.Speed);
    }



}