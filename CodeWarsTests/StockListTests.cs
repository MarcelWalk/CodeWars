using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Tests
{
    [TestClass()]
    public class StockListTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
            String[] cd = new String[] { "A", "B" };
            Assert.AreEqual("(A : 200) - (B : 1140)", StockList.Solution(art, cd));
        }
    }
}