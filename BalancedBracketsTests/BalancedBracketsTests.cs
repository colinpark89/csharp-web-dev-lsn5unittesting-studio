using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void StringInBracketReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[String]"));
        }

        [TestMethod]
        public void StringOutsideBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("String[]"));
        }

        [TestMethod]
        public void StringOutsideAndInsideBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("String[String]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void MultipleClosedBracketsgReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

        [TestMethod]
        public void MissingSecondBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[String"));
        }

        [TestMethod]
        public void MissingFirstBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("String]"));
        }

        [TestMethod]
        public void OnlyOpeningBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void OnlyClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void ClosedBracketFirstReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void CloseddBracketFirstWithStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]String["));
        }
    }
}
