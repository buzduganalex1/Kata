using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class ArithmeticProgressionTest
    {
        [TestMethod]
        public void TestCase1()
        {
            Assert.AreEqual(FindMissing(new List<int> { 1, 3, 5, 9, 11 }), 7);            
        }

        [TestMethod]
        public void TestCase2()
        {
            Assert.AreEqual(FindMissing(new List<int> { 0, 5, 10, 20, 25 }), 15);
        }

        [TestMethod]
        public void TestCase3()
        {
            Assert.AreEqual(FindMissing(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 }), 10);
        }

        [TestMethod]
        public void TestCase4()
        {
            Assert.AreEqual(FindMissing(new List<int> { 1040, 1220, 1580 }), 1400);
        }

        public static int FindMissing(List<int> list)
        {
            if (list.Count < 1)
            {
                return 0;
            }

            var difference = list[1] - list[0];
            
            for (var i = 1; i <= list.Count; i++)
            {
                if (list[i] != list[i - 1] + difference)
                {
                    return list[i] - difference;
                }
            }

            return 0;
        }

    }
}
