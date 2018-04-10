using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MiddleCharacterTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("es", GetMiddle("test"));
            Assert.AreEqual("t", GetMiddle("testing"));
            Assert.AreEqual("dd", GetMiddle("middle"));
            Assert.AreEqual("A", GetMiddle("A"));
        }

        public string GetMiddle(string s)
        {
            var isOdd = s.Length % 2 == 0;

            return s.Substring(isOdd ? s.Length / 2 - 1 : s.Length / 2, isOdd ? 2 : 1);
        }
    }
}
