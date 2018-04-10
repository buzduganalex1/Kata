using KataTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class PlayingWithPassphrasesTest
    {
        private IPassPhraseHelper passPhraseHelper;
        
        [TestInitialize]
        public void Initialize()
        {
            passPhraseHelper = new PassPhraseHelper();
        }

        [TestMethod]
        public void ShouldReverseString()
        {
            Assert.AreEqual("tseT", passPhraseHelper.ReverseString("Test"));
        }

        [TestMethod]
        public void ShouldReplaceNumbersWith9Equivalent()
        {
            Assert.AreEqual("8765", passPhraseHelper.ReplaceNumbersWith9Equivalent("1234"));
        }

        [TestMethod]
        public void ShouldCycleSimpleLetter()
        {
            Assert.AreEqual("BCDA", passPhraseHelper.ShiftLettersByNumber("ABCZ", 1));
        }

        [TestMethod]
        public void ShouldConvertCorrectlyUpperAndLower()
        {
            Assert.AreEqual("Y", passPhraseHelper.ShiftLettersByNumber("Z", 25));
        }

        [TestMethod]
        public void LowerCaseEvenUppercaseOdd()
        {
            Assert.AreEqual("TeSt", passPhraseHelper.LowerCaseEvenUppercaseOdd("test"));
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("!!!vPz fWpM J", this.playPass("I LOVE YOU!!!", 1));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO",
                this.playPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("I LoVe yOu!!!", this.playPass("!!!VPZ FWPM J", 25));
        }

        private string playPass(string s, int n)
        {
            var numberReplaced = passPhraseHelper.ReplaceNumbersWith9Equivalent(s);

            var shiftLetter = passPhraseHelper.ShiftLettersByNumber(numberReplaced, n);

            var lowerCase = passPhraseHelper.LowerCaseEvenUppercaseOdd(shiftLetter);

            var reversed = passPhraseHelper.ReverseString(lowerCase);

            return reversed;
        }

    }
}