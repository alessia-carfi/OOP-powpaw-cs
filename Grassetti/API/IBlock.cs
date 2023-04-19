using System.Numerics;

namespace PowPaw
{
    public interface IBlock
    {
        double Width { get; set; }
        double Height { get; set; }
        Vector2 Position { get; set; }

        void SetX(float x);
        void SetY(float y);
    }
}