using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using PowPaw;

namespace PlayerTest;

[TestClass]
public class UnitPlayerTest
{
    private const int DEBUG_PLAYER_NUMBER = 1;
    private const double DEBUG_PLAYER_WIDHT = 5;
    private const double DEBUG_PLAYER_HEIGHT = 10;

    private readonly Player _player = new Player(Vector2.Zero, DEBUG_PLAYER_NUMBER);


    [TestMethod]
    public void NumberTest()
    {
        Assert.AreEqual(_player.Number, DEBUG_PLAYER_NUMBER);
    }

    [TestMethod]
    public void InitialPositionTest()
    {
        Assert.AreEqual(_player.Position, Vector2.Zero);
    }

    [TestMethod]
    public void SizeTest()
    {
        _player.Height = DEBUG_PLAYER_HEIGHT;
        Assert.AreEqual(_player.Height, DEBUG_PLAYER_HEIGHT);

        _player.Width = DEBUG_PLAYER_WIDHT;
        Assert.AreEqual(_player.Width, DEBUG_PLAYER_WIDHT);
    }

    [TestMethod]
    public void DirectionTest()
    {
        Vector2 direction = Vector2.One;

        _player.Direction = direction;
        Assert.AreEqual(_player.Direction, direction);
    }

    [TestMethod]
    public void StateTest()
    {
        _player.State = Player.PlayerState.ATTACK;
        Assert.AreEqual(_player.State, Player.PlayerState.ATTACK);

        _player.State = Player.PlayerState.IDLE;
        Assert.AreEqual(_player.State, Player.PlayerState.IDLE);
    }
}