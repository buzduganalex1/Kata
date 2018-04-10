namespace Tests
{
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ConsecutiveStrings
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(LongestConsec(new[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");
            Assert.AreEqual(LongestConsec(new [] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1), "oocccffuucccjjjkkkjyyyeehh");
            Assert.AreEqual(LongestConsec(new string[] { }, 3), "");
            Assert.AreEqual(LongestConsec(new [] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
            Assert.AreEqual(LongestConsec(new [] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
            Assert.AreEqual(LongestConsec(new [] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");
            Assert.AreEqual(LongestConsec(new [] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3), "ixoyx3452zzzzzzzzzzzz");
            Assert.AreEqual(LongestConsec(new [] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
            Assert.AreEqual(LongestConsec(new [] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");

        }
        public string LongestConsec(string[] strarr, int k)
        {
            if (!strarr.Any() || k <= 0 || k > strarr.Length)
            {
                return string.Empty;
            }
            
            return string.Join("", strarr.OrderByDescending(x => x.Length).Distinct().Take(k));
        }
    }
}