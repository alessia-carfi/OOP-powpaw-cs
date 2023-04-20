using PowPaw;

namespace Tests;

[TestClass]
public class WeaponTest
{
    private const int DEBUG_DURABILITY = 1;
    private const int WEAPOIN_ID_ZERO = 0;
    private const int WEAPOIN_ID_ONE = 1;


    [TestMethod]
    public void WeaponDurabilityTest()
    {
        Weapon sword = WeaponFactory.CreateWeapon(WEAPOIN_ID_ZERO);
        int maxDurability = sword.Durability;
        for (int i = 1; i < maxDurability; i++)
        {
            sword.DecrementDurability();
        }
        Assert.AreEqual(DEBUG_DURABILITY, sword.Durability);
    }

    [TestMethod]
    public void WeaponFactoryTest()
    {
        Weapon sword = WeaponFactory.CreateWeapon(WEAPOIN_ID_ZERO);
        Assert.AreEqual(WEAPOIN_ID_ZERO, sword.Id);
        Weapon hammer = WeaponFactory.CreateWeapon(WEAPOIN_ID_ONE);
        Assert.AreEqual(WEAPOIN_ID_ONE, hammer.Id);
    }
}