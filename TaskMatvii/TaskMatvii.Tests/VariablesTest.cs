using NUnit.Framework;

namespace TaskMatvii.Tests
{
    public class VariablesTest
    {
        [TestCase(2, 3, 19)]
        [TestCase(0, 5, 5)]
        [TestCase(4, 0, -5)]
        [TestCase(10, 4, -11)]
        public void SolvingEquationsTest(int a, int b, int expected)
        {
            int actual = Variables.SolvingEquations(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 3, 2)]
        [TestCase(0, 5, 5, 0)]
        [TestCase(4, -3, -3, 4)]
        [TestCase(10, 4, 4, 10)]
        public void ReplacementOfValuesTests(int a, int b, int expectedA, int expectedB)
        {
            Variables.ReplacementOfValues(ref a, ref b);
            int actualA = a;
            int actualB = b;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(2, 2, new int[] { 1, 0 })]
        [TestCase(5, 2, new int[] { 2, 1 })]
        [TestCase(17, 5, new int[] { 3, 2 })]
        [TestCase(-21, 10, new int[] { -2, -1 })]

        public void DivisionAndRemainderDivisionTests(int a, int b, int[] expected)
        {
            int[] actual = Variables.DivisionAndRemainderDivision(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(2, 5, 5, 0)]
        [TestCase(4, 0, 8, 2)]
        [TestCase(-2, 4, 12, -4)]
        public void SolvingLinearEquationTests(int a, int b, int c, int expected)
        {
            int actual = Variables.SolvingLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 2, 2, new int[] { 1, 0 })]
        [TestCase(0, -2, 2, 6, new int[] { 4, -2 })]
        [TestCase(5, 10, 10, 5, new int[] { -1, 15 })]
        [TestCase(4, 1, 7, 2, new int[] { 0, 1 })]
        public void MappinglineEquationTests(int x1, int y1, int x2, int y2, int[] expected)
        {
            int[] actual = Variables.MappinglineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }
    }
}