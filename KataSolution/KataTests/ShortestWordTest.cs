namespace Tests
{
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShortestWordTest
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, FindShort("turns out random test cases are easier than writing out basic ones"));
        }

        private int FindShort(string turnsOutRandomTestCasesAreEasierThanWritingOutBasicOnes)
        {
            return turnsOutRandomTestCasesAreEasierThanWritingOutBasicOnes.Split(' ').Min(x => x.Length);
        }
    }
}