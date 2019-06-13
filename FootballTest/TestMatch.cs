using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
using System.Collections.Generic;

namespace FootballTest
{
    [TestClass]
    public class TestMatch
    {
        private Match match;
        private int maximumNumOfTeam = 3;
        public TestMatch()
        {
            match = new Match();
        }

        public PropertyInfo[] GetProperties(object target, Type type)
        {
            PropertyInfo[] props = target.GetType().GetProperties();
            List<PropertyInfo> result = new List<PropertyInfo>();
            for (int i = 0; i < props.Length; i++)
            {
                if (props[i].PropertyType == type)
                {
                    result.Add(props[i]);
                }
            }
            return result.ToArray();
        }

        [TestMethod]
        public void TestTeamProperties()
        {
            PropertyInfo[] result = GetProperties(new Match(), typeof(Team));
            Assert.AreEqual(maximumNumOfTeam, result.Length);
        }

        [TestMethod]
        public void TestMatchDate()
        {
            PropertyInfo[] result = GetProperties(new Match(), typeof(DateTime));
            Assert.AreEqual(1, result.Length);
        }


    }
}
