namespace PowPaw
{
    public sealed class BlockFactory
    {
        private BlockFactory()
        {
            throw new InvalidOperationException("Utility class");
        }

        public static BlockImpl CreateBlock(double x, double y)
        {
            return new BlockImpl(new Vector2(x, y), 1, 1);
        }
    }
}