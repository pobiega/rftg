using RollForTheGalaxy.Game.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Controllers
{
    class StateController
    {
        public State State { get; }

        public StateController(int playerCount)
        {
            State = new State(playerCount);
        }
    }
}
