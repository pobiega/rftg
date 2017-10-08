using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public class TileBag
    {
        private List<Tile> tiles;
        private Random rnd;

        public TileBag(IEnumerable<Tile> initalTiles, Random random)
        {
            tiles = new List<Tile>(initalTiles);
            this.rnd = random;
        }

        public Tile Draw()
        {
            if (!tiles.Any())
                return null;

            var tile = tiles[rnd.Next(tiles.Count)];
            tiles.Remove(tile);

            return tile;
        }

        public IEnumerable<Tile> Draw(int count)
        {
            for (int i = 0; i < count; i++)
                yield return Draw();
        }

        public Tile[] GetHomeWorlds()
        {
            throw new NotImplementedException();
        }
    }
}
