using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Tests
{
    [TestClass()]
    public class MultiplesOf3Or5Tests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            Assert.AreEqual(23, MultiplesOf3Or5.Solution(10));
        }
    }
}