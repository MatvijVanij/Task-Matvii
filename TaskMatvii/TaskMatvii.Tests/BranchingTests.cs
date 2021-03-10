
using NUnit.Framework;

namespace TaskMatvii.Tests
{
    public class BranchingTests
    {
        [TestCase(4, 1, 5)]
        [TestCase(0, 5, -5)]
        [TestCase(4, 4, 16)]
        [TestCase(10, 4, 14)]
        public void CalculationProvidedTests(int a, int b, int expected)
        {
            int actual = Branching.CalculationProvided(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 1, 1)]
        [TestCase(-1, -5, 3)]
        [TestCase(1, -14, 2)]
        [TestCase(-10, 4, 4)]
               public void DeterminingLocationPointTests(int x, int y, int expected)
        {
            int actual = Branching.DeterminingLocationPoint(x, y);
            Assert.AreEqual(expected, actual);
        }
    }

}
