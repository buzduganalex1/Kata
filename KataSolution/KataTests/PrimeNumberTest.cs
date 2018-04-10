namespace KataTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(IsPrime(2));

            Assert.IsFalse(IsPrime(1));

            Assert.IsFalse(IsPrime(0));
        }

        private bool IsPrime(int n)
        {
            return true;
        }
    }
}