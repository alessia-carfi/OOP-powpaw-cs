using System.Numerics;

namespace PowPaw
{
    public sealed class BlockFactory
    {
        private BlockFactory()
        {
            throw new InvalidOperationException("Utility class");
        }

        public static Block CreateBlock(float x, float y)
        {
            return new Block(new Vector2(x, y), 1, 1);
        }
    }
}