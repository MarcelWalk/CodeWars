using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class NarcissisticTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                                .Returns(true)
                                .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                                .Returns(true)
                                .SetDescription("371 is narcissitic");

            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => NarcissisticNumber.Solution(n);
    }
}