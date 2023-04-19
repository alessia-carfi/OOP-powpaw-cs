using PowPaw;

namespace Tests;

[TestClass]
public class GameMapTest
{

    private const float DEBUG_POSITION_1 = 200;
    private const float DEBUG_POSITION_2 = 250;

    [TestMethod]
    public void CheckTerrainTest()
    {
        CreateMap map = new CreateMap();
        List<Block> terrainTest = map.getTerrains();
        terrainTest.Add(BlockFactory.CreateBlock(0, 0));
        Assert.AreEqual(terrainTest.Count, map.getTerrains().Count);
    }

    [TestMethod]
    public void CheckBlockPositionTest()
    {
        int x = 400;
        Block blockOne = BlockFactory.CreateBlock(DEBUG_POSITION_1, DEBUG_POSITION_1);
        blockOne.SetX(x);
        Block blockTwo = BlockFactory.CreateBlock(DEBUG_POSITION_2, DEBUG_POSITION_1);
        blockTwo.SetX(x);
        Assert.AreEqual(blockOne.Position, blockTwo.Position);
    }
}