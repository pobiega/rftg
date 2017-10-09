using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RollForTheGalaxy.Game.Effects;

namespace RollForTheGalaxy.Game.Model
{
    public class Player : ITarget
    {
        public List<Dice> DicePool { get; }
        public Tableau Tableau { get; }

        public Player()
        {

        }

        public bool ApplyEffect(Effect effect)
        {
            throw new NotImplementedException();
        }
    }
}
