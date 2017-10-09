using RollForTheGalaxy.Game.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public class TileBase
    {
        public string Name { get; }
        public int Cost { get; }
        public string Description { get; }

        public Effect[] Effects { get; }

        public TileBase(string name, int cost, string description)
        {
            this.Name = name;
            this.Cost = cost;
            this.Description = description;

            this.Effects = null;
        }

        public TileBase(string name, int cost, string description, Effect[] effects)
            : this(name, cost, description)
        {
            this.Effects = effects;
        }
    }
}
