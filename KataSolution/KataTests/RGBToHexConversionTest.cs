using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class RGBToHexConversionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("FFFFFF", Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", Rgb(255, 255, 300));
            Assert.AreEqual("000000", Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }

        private string Rgb(int p0, int p1, int p2)
        {
            return string.Format($"{ToHex(p0)}{ToHex(p1)}{ToHex(p2)}");
        }

        static string ToHex(int value)
        {
            var convertedValue = value.ToString("X");

            return value <= 0
                ? "00"
                : value > 255
                    ? "FF"
                    : convertedValue.Length == 1
                        ? string.Format($"0{convertedValue}")
                        : convertedValue;
        }
    }
}
