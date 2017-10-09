using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RollForTheGalaxy.Game.Model;

namespace RollForTheGalaxy.Game.Effects
{
    public enum Trigger
    {
        WhenTileComplete
    }

    public enum Target
    {
        Player,
        PlayerCup,
        Tile,
        Die
    }

    public enum EffectType
    {
        GainMoney,
        GainDie
    }

    public class Effect
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public EffectType Type { get; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Trigger Trigger { get; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Target Target { get; }

        public Effect(EffectType type, Trigger trigger, Target target)
        {
            this.Type = type;
            this.Trigger = trigger;
            this.Target = target;
        }

        public bool Apply(ITarget target)
        {
            return target.ApplyEffect(this);
        }
    }
}