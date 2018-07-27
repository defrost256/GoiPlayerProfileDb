using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoiPlayerProfileDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoiPlayerProfileDB.Tests
{
    [TestClass()]
    public class StingDistanceComparerTests
    {
        [TestMethod()]
        public void LevenshteinTest()
        {
            Assert.AreEqual(0, GoiPlayerProfileDB.StingDistanceComparer.Levenshtein("kuka", "kuka"));
            Assert.AreEqual(1, GoiPlayerProfileDB.StingDistanceComparer.Levenshtein("kula", "kuka"));
            Assert.AreEqual(2, GoiPlayerProfileDB.StingDistanceComparer.Levenshtein("kutya", "kuka"));
            Assert.AreEqual(1, GoiPlayerProfileDB.StingDistanceComparer.Levenshtein("kukac", "kuka"));
            Assert.AreEqual(1, GoiPlayerProfileDB.StingDistanceComparer.Levenshtein("kuk", "kuka"));
            Assert.AreEqual(1, GoiPlayerProfileDB.StingDistanceComparer.Levenshtein("kka", "kuka"));
            Assert.AreEqual(1, GoiPlayerProfileDB.StingDistanceComparer.Levenshtein("kukka", "kuka"));
            Assert.AreEqual(1, GoiPlayerProfileDB.StingDistanceComparer.Levenshtein("luka", "kuka"));
        }
    }
}