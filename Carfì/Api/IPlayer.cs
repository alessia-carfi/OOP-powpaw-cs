using System.Numerics;

namespace PowPaw
{
    public interface IPlayer
    {
        int Number { get; }
        Vector2 Position { get; }
        Vector2 Direction { get; set; }
        double Width { get; set; }
        double Height { get; set; }
        Player.PlayerState State { get; set; }
        bool IsJumping { set; }
        bool IsMovingLeft { set; }
        bool IsMovingRight { set; }
        bool IsAttacking { set; }
        bool IsDodging { set; }
        void Idle();
        void Update();
    }

}