using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public enum TileSide
    {
        Development,
        Planet
    }

    public class Tile
    {
        private List<Dice> assignedDice;

        public Planet Planet { get; }
        public Development Development { get; }
        public TileSide ActiveSide { get; }

        public Tile(Planet planet, Development development)
        {
            assignedDice = new List<Dice>();
            this.Planet = planet;
            this.Development = development;
        }

        public Dice[] ReturnAssignedDice()
        {
            var dice = assignedDice.ToArray();
            assignedDice.Clear();
            return dice;
        }

        public void AssignDice(params Dice[] dice)
        {
            assignedDice.AddRange(dice);
        }

        public Dice[] GetAssignedDice()
        {
            return assignedDice.ToArray();
        }
    }
}
