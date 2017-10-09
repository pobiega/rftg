using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RollForTheGalaxy.Game.Model;

using Newtonsoft.Json;
using RollForTheGalaxy.Game.Effects;

namespace RollForTheGalaxy.Serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Effect> alienBattleFleetEffects = new List<Effect>();

            alienBattleFleetEffects.Add(new GainMoneyEffect(Trigger.WhenTileComplete, Target.Player, 3));
            alienBattleFleetEffects.Add(new GainDieEffect(Trigger.WhenTileComplete, Target.PlayerCup, Color.Yellow, 1));

            var planet = new Planet("Lost Alien Battle Fleet", 6, "Gain $3 and an Alien Technology (yellow) die into your cup when you place this world.", Color.Yellow, alienBattleFleetEffects.ToArray());

            var development = new Development("Galactic Federation", 6, "DEVELOP: When completing each development (after this one), put one or two of the developers used into your cup instead of your Citizenry.");

            var tile = new Tile(planet, development);

            string json = JsonConvert.SerializeObject(tile);

            Console.WriteLine(json);

            Console.Read();
        }
    }
}
