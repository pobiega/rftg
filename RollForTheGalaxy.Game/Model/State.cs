using RollForTheGalaxy.Game.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game
{
    class State
    {
        public TileBag TileBag { get; }
        public List<Player> Players { get; }
        public int TurnCount { get; private set; }
        private Random random;

        public State(int playerCount)
        {
            random = new Random();

            TileBag = new TileBag(null, random);
            Players = new List<Player>();

            for (int i = 0; i < playerCount; i++)
            {
                Players.Add(new Player());
            }

        }
    }
}
