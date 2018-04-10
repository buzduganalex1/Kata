namespace KataTests
{
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindingMissingLetterTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual('e', FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual('P', FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }
        
        private char FindMissingLetter(char[] c)
        {
            var orderedEnumerable = c.OrderBy(x => x).ToArray();

            for (var i = 0; i < c.Length; i++)
            {
                if (orderedEnumerable[i] != orderedEnumerable[i + 1] - 1)
                {
                    return (char)(orderedEnumerable[i + 1] - 1);
                }
            }

            return ' ';
        }
    }
}