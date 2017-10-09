using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RollForTheGalaxy.Game.Effects;

namespace RollForTheGalaxy.Game.Model
{
    public class Planet : TileBase
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Color Color { get; }

        public Planet(string name, int cost, string description, Color color)
            : base(name, cost, description)
        {
            this.Color = color;
        }

        public Planet(string name, int cost, string description, Color color, Effect[] effects)
            : base(name, cost, description, effects)
        {
            this.Color = color;
        }
    }
}