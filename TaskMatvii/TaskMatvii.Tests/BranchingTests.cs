
using NUnit.Framework;

namespace TaskMatvii.Tests
{
    public class BranchingTests
    {
        [TestCase(4, 1, 5)]
        [TestCase(0, 5, -5)]
        [TestCase(4, 4, 16)]
        [TestCase(10, 4, 14)]
        public void CalculationProvided_WhenAMoreEqwelLessb_ShoudSumMultiplicationOrSubtraction(int a, int b, int expected)
        {
            int actual = Branching.CalculationProvided(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 1, 1)]
        [TestCase(-1, -5, 3)]
        [TestCase(1, -14, 2)]
        [TestCase(-10, 4, 4)]
        public void DeterminingLocationPoint_WhenAandBPointCoordinates_ShouldPointliesInQuarter(int x, int y, int expected)
        {
            int actual = Branching.DeterminingLocationPoint(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 1, 1, new int[] { 1, 1, 4 })]
        [TestCase(-1, -5, 3, new int[] { -5, -1, 3 })]
        [TestCase(1, -14, 2, new int[] { -14, 1, 2 })]
        [TestCase(-10, 4, 0, new int[] { -10, 0, 4 })]
        public void SortingThreeElementsBrancing_WhenAandBandCneedSort_ShoudIncreaseValue(int a, int b, int c, int[] expected)
        {
            int[] actual = Branching.SortingThreeElementsBrancing(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, new double[] { 0, 0 })]
        [TestCase(5, 10, 5, new double[] { -1, -1 })]
        [TestCase(2, 10, 8, new double[] { -1, -4 })]
        public void EquationSolution_WhenAandBandCConstansQuadraticEquations_ShoudSolutionQuadraticEquations(double a, double b, double c, double[] expected)
        {
            double[] actual = Branching.EquationSolution(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(24, "Двадцять  четыри")]
        [TestCase(11, "Одинадцать  ")]
        [TestCase(61, "Шестдесят  один")]

        public void NumberStamp_WhenAisNumber_ShoudCapitalizedNumber(int a, string expected)
        {
            string actual = Branching.NumberStamp(a);
            Assert.AreEqual(expected, actual);
        }
    }


}
