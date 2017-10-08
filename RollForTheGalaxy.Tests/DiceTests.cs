using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollForTheGalaxy.Game;
using RollForTheGalaxy.Game.Model;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void DiceBag_Test()
        {
            var diceBag = new DiceBag();
            var createdDice = diceBag.Get(Color.White, 5).ToList();
            createdDice.AddRange(diceBag.Get(Color.Red, 2));
            createdDice.Add(diceBag.Get(Color.Cyan));

            Assert.IsTrue(createdDice.Where(d => d.Color == Color.White).Count() == 5);
            Assert.IsTrue(createdDice.Where(d => d.Color == Color.Red).Count() == 2);
            Assert.IsTrue(createdDice.Where(d => d.Color == Color.Cyan).Count() == 1);
            Assert.IsFalse(createdDice.Any(d => d.Color == Color.Green));
            Assert.IsFalse(createdDice.Any(d => d == null));

            createdDice.AddRange(diceBag.Get(Color.Yellow, 11));

            //Only 9 yellow in the dice bag
            Assert.IsTrue(createdDice.Where(d => d == null).Count() == 2);
        }
    }
}
