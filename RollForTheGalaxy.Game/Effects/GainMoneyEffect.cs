using RollForTheGalaxy.Game.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Effects
{
    public class GainMoneyEffect : Effect
    {
        public int Amount { get; }
        public GainMoneyEffect(Trigger trigger, Target target, int amount) : base(EffectType.GainMoney, trigger, target)
        {
            this.Amount = amount;
        }
    }
}
