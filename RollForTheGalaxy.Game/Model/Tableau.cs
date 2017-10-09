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
        public int Money { get; private set; }

        public Tableau(Player owner)
        {
            this.Owner = owner;
        }

        public int AddMoney(int addition)
        {
            this.Money += addition;

            if (this.Money > 10)
                this.Money = 10;

            return this.Money;
        }
    }
}
