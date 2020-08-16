using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars.Tests
{
    [TestClass()]
    public class TopWordsTests
    {
        public void Equal(List<string> expected, List<string> given)
        {
            if (expected.Count != given.Count)
                Assert.Fail();

            for (int i = 0; i < expected.Count; i++)
            {
                    Assert.IsTrue(expected.ElementAt(i) == given.ElementAt(i), "Differ at index "  + i);
            }
        }

        [TestMethod()]
        public void Top3Test()
        {
            Equal(new List<string> { "e", "d", "a" }, TopWords.Top3("a a a  b  c c  d d d d  e e e e e"));
            Equal(new List<string> { "e", "ddd", "aa" }, TopWords.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"));
            Equal(new List<string> { "won't", "wont" }, TopWords.Top3("  //wont won't won't "));
            Equal(new List<string> { "e" }, TopWords.Top3("  , e   .. "));
            Equal(new List<string> { }, TopWords.Top3("  ...  "));
            Equal(new List<string> { }, TopWords.Top3("  '  "));
            Equal(new List<string> { }, TopWords.Top3("  '''  "));
            Equal(new List<string> { "a", "of", "on" }, TopWords.Top3(
                string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
                  "mind, there lived not long since one of those gentlemen that keep a lance",
                  "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                  "coursing. An olla of rather more beef than mutton, a salad on most",
                  "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                  "on Sundays, made away with three-quarters of his income." })));
        }
    }
}