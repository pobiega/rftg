using RollForTheGalaxy.Game.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Effects
{
    public class GainDieEffect : Effect
    {
        public Color Color { get; }
        public int Amount { get; }

        public GainDieEffect(Trigger trigger, Target target, Color color, int amount) : base(EffectType.GainDie, trigger, target)
        {
            this.Color = color;
            this.Amount = amount;
        }
    }
}
