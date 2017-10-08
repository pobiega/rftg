using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public class Tile
    {
        public int Cost { get; }
        private List<Dice> assignedDice;

        public Tile(int cost)
        {
            this.Cost = cost;
            assignedDice = new List<Dice>();
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
