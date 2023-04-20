using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerUpAndStats;

namespace PowerUpAndStatsTest;

[TestClass]
public class PowerUpTest
{
    [TestMethod]
    public async Task AttackPowerUpTest()
    {
        PlayerStats stats = new PlayerStats(4, 5, 6);
        PowerUp powup = new AttackPowerUp();
        double expectedValue = stats.Attack + 2;
        double oldvalue = stats.Attack;
        powup.StatPowerUp(stats);
        Assert.AreEqual(expectedValue, stats.Attack);
        await Task.Delay(8000); //additional second added because the task is not completed always in 7000 ms
        Assert.AreEqual(oldvalue, stats.Attack);
    }

    [TestMethod]
    public async Task SpeedPowerUpTest()
    {
        PlayerStats stats = new PlayerStats(4, 5, 6);
        PowerUp powup = new SpeedPowerUp();
        double expectedValue = stats.Speed + 2;
        double oldvalue = stats.Speed;
        powup.StatPowerUp(stats);
        Assert.AreEqual(expectedValue, stats.Speed);
        await Task.Delay(8000);
        Assert.AreEqual(oldvalue, stats.Speed);
    }



}