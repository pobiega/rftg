using RollForTheGalaxy.Game.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public interface ITarget
    {
        bool ApplyEffect(Effect effect);
    }
}
