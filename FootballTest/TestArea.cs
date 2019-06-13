using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;

namespace FootballTest
{
    [TestClass]
    public class TestArea
    {
        [TestMethod]
        public void AsiaRateIsCorrect()
        {
            Assert.AreEqual(true, AreaCountry.GetRateFromArea(Area.Asia) == 5.5d);
        }
        [TestMethod]
        public void EuropeRateIsCorrect()
        {
            Assert.AreEqual(true, AreaCountry.GetRateFromArea(Area.Europe) == 13d);
        }
        [TestMethod]
        public void AfricaRateIsCorrect()
        {
            Assert.AreEqual(true, AreaCountry.GetRateFromArea(Area.Africa) == 5d);
        }
        [TestMethod]
        public void NorthAmericaRateIsCorrect()
        {
            Assert.AreEqual(true, AreaCountry.GetRateFromArea(Area.NorthAmerica) == 3.5d);
        }
        [TestMethod]
        public void SouthAmericaRateIsCorrect()
        {
            Assert.AreEqual(true, AreaCountry.GetRateFromArea(Area.SouthAmerica) == 3.5d);
        }
        [TestMethod]
        public void OceaniaRateIsCorrect()
        {
            Assert.AreEqual(true, AreaCountry.GetRateFromArea(Area.Oceania) == 0.5d);
        }
    }
}
