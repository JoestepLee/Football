﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Football;
using Football.Data;

namespace FootballTest
{
    [TestClass]
    public class TestWorldCup
    {
        Worldcup worldCup;
        private void Init(IProvider provider)
        {
            worldCup = new Worldcup();
            worldCup.TeamProvider = provider;
            worldCup.RoundList.Add(new PreRound());
            worldCup.RoundList.Add(new PlayOff());
            worldCup.RoundList.Add(new OctRound());
            worldCup.RoundList.Add(new QuadRound());
            worldCup.RoundList.Add(new FinalRound());
        }

        [TestMethod]
        public void PlayWorldCup()
        {
            Init(new TextProvider());
            worldCup.Play();
            Assert.IsNotNull(worldCup.Championship);
        }
        [TestMethod]
        public void PlayWorldCupWithSql()
        {
            Init(new SqlProvider());
            worldCup.Play();
            Assert.IsNotNull(worldCup.Championship);
        }
    }
}
