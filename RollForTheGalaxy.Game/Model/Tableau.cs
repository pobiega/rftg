using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public class Tableau
    {
        public Player Owner { get; }
        public List<Tile> Tiles { get; }

        public Tableau(Player owner)
        {
            this.Owner = owner;
        }
    }
}
