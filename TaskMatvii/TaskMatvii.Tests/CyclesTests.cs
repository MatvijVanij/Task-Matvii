using NUnit.Framework;

namespace TaskMatvii.Tests
{
    class CyclesTests
    {
        [TestCase(4, 1, 4)]
        [TestCase(-1, 7, -1)]
        [TestCase(9, 5, 59049)]
        [TestCase(2, 10, 1024)]
        [TestCase(4, 0, 1)]
        public void Exponentiation_WhenARaiseToB_ShouldAMultipliedBtimes(double a, double b, double expected)
        {
            double actual = Cycles.Exponentiation(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 10, new int[] { 2, 4, 6, 8, 10 })]
        [TestCase(50, 100, new int[] { 50, 100 })]
        [TestCase(30, 100, new int[] { 30, 60, 90 })]
        public void OutputNumbersDivisibleA_WhenADivider_ShouldArrayValueDividedIntoARangeFromZeroToB(int a, int b, int[] expected)
        {
            int[] actual = Cycles.OutputNumbersDivisibleA(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(100, 10)]
        [TestCase(10, 4)]
        [TestCase(50, 8)]
        [TestCase(1, 1)]
        public void NumberPositiveIntegersSquare_WhenAisDianazonBorder_ShouldCountValueSquareLessA(int a, int expected)
        {
            int actual = Cycles.NumberPositiveIntegersSquare(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(57, 19)]
        [TestCase(100, 50)]
        [TestCase(21, 7)]
        [TestCase(28, 14)]
        public void PrintGreatestВiviso_WhenAisBiggerDivider_ShouldbiggerFrontA(int a, int expected)
        {
            int actual = Cycles.PrintGreatestВivisor(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
