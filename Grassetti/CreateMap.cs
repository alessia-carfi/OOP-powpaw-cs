using System.Collections.Generic;
namespace PowPaw
{
    public class CreateMap {
        private List<BlockImpl> terrains = new List<BlockImpl>();

        /**
        * Constructor of CreateMap.
        */
        public CreateMap() {
            createTerrains();
        }

        private void createTerrains() {
            for (int y = 0; y < Level.LEVEL2.Length; y++) {
                string row = Level.LEVEL2[y];
                for (int x = 0; x < row.Length; x++) {
                    switch (row[x]) {
                        case '1':
                            BlockImpl block = BlockFactory.createBlock(x, y);
                            terrains.Add(block);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public List<BlockImpl> getTerrains() {
            return terrains;
        }
    }

}
