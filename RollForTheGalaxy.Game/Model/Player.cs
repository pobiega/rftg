﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public class Player
    {
        public List<Dice> DicePool { get; }
        public Tableau Tableau { get; }

        public Player()
        {

        }
    }
}
