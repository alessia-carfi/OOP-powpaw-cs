namespace PowPaw
{
    public class CreateMap
    {
        private List<Block> terrains = new List<Block>();

        public CreateMap()
        {
            createTerrains();
        }

        private void createTerrains()
        {
            for (int y = 0; y < Level.LEVEL2.Length; y++)
            {
                string row = Level.LEVEL2[y];
                for (int x = 0; x < row.Length; x++)
                {
                    switch (row[x])
                    {
                        case '1':
                            Block block = BlockFactory.CreateBlock(x, y);
                            terrains.Add(block);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public List<Block> getTerrains()
        {
            return terrains;
        }
    }

}
