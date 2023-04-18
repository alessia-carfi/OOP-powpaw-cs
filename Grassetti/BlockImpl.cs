namespace PowPaw
{
    public class BlockImpl : Block
    {
        private Vector2 position;
        public double Width { get; set; }
        public double Height { get; set; }

        public BlockImpl(Vector2 pos, double width, double height)
        {
            Position = new Vector2(pos.X * ScreenController.SIZE_HD_W / ScreenController.NUM_BLOCK_W,
                pos.Y * ScreenController.SIZE_HD_H / ScreenController.NUM_BLOCK_H);
            Width = width;
            Height = height;
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = new Vector2(value.X, value.Y); }
        }

        public void SetX(double x)
        {
            Position = new Vector2(x, Position.Y);
        }

        public void SetY(double y)
        {
            Position = new Vector2(Position.X, y);
        }
    }
}