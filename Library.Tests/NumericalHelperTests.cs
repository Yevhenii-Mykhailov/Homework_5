using System;
using NUnit.Framework;

namespace Library.Tests
{
    public class NumericalHelperTests
    {
        [TestCase(1, 60)]
        [TestCase(5, 300)]
        public void ConvertHoursToMinutes_WhenInputMoreThenZero_ShouldReturnNumberOfMinuts
            (int a, int expected)
        {
            int actual = NumericalHelper.ConvertHoursToMinutes(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void ConvertHoursToMinutes_WhenInputLessOrEqualToZero_ShouldThrowArgumentException
            (int a)
        {
            Assert.Throws<ArgumentException>(() =>
           {
               NumericalHelper.ConvertHoursToMinutes(a);
           });
        }

        [TestCase(10, 4, -11)]
        [TestCase(-7, 12, 5.7368f)]
        [TestCase(8, -11, -8.4736f)]
        [TestCase(-3, -9, -11)]
        public void CalculateFormula_WhenAAndBAreNotEqual_ShouldCalculateByFormula
            (int a, int b, float expected)
        {
            float actual = NumericalHelper.CalculateFormula(a, b);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestCase(6, 6)]
        public void CalculateFormula_WhenAAndBAreEqual_ShoulThrowArgumentException
            (int a, int b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                NumericalHelper.CalculateFormula(a, b);
            });
        }

        [TestCase(2, 5, 5, 2)]
        [TestCase(11, 0, 0, 11)]
        [TestCase(7, 7, 7, 7)]
        public void SwapValues_WhenValuesPassed_ShouldSwapValues
            (int a, int b, int expectedA, int expectedB)
        {
            (int a, int b) actual = NumericalHelper.SwapValues(a, b);
            (int a, int b) expected = (expectedA, expectedB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 15.2, 0.3289d, 5)]
        [TestCase(7.1, -2.5, -2.84d, 2.099d)]
        [TestCase(-8, -2, 4, 0)]
        public void CalculateDividingAndDivisionRemainder_WhenValuesAreNotEqualZero_ShoudReturnDividingAndDivisionRemainder
            (double a, double b, double expectedDividing, double expectedDivisionRemainder)
        {
            (double a, double b) actual = NumericalHelper.CalculateDividingAndDivisionRemainder(a, b);
            (double a, double b) expected = (expectedDividing, expectedDivisionRemainder);

            Assert.AreEqual(expected.a, actual.a, 0.001d);
            Assert.AreEqual(expected.b, actual.b, 0.001d);
        }

        [TestCase(2, 0)]
        public void CalculateDividingAndDivisionRemainder_WhenBEqualToZero_ShouldThrowArgumentException
            (double a, double b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                NumericalHelper.CalculateDividingAndDivisionRemainder(a, b);
            });
        }

        [TestCase(5, 15, -7, -10)]
        [TestCase(7.1, -2.5, -5.6, -5.2478d)]
        [TestCase(-8, -2, -3, -3.25d)]
        [TestCase(7, 2, 11, 10.7142d)]
        public void CalculateExpressionByFormula_WhenANotEqualToZero_ShoudReturnResult
            (double a, double b, double c, double expected)
        {
            double actual = NumericalHelper.CalculateExpressionByFormula(a, b, c);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestCase(0, 3, -77)]
        public void CalculateExpressionByFormula_WhenAEqualToZero_ShoudThrowArgumentException
            (double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                NumericalHelper.CalculateExpressionByFormula(a, b, c);
            });
        }

        [TestCase(1, 2, 3, 4, 1, 1)]
        [TestCase(-2, -4, 2, 3, 1.75f, -0.5f)]
        [TestCase(7, 1, -2, -2, 0.3333f, -1.3333f)]
        [TestCase(-1, -2, -3, -4, 1, -1)]
        public void GetLineEquation_WhenX1AndX2AreNotEqual_ShoudReturnArgumentsOfLineEquation
            (float x1, float y1, float x2, float y2,
             float expectedA, float expectedB)
        {
            (float a, float b) actual = NumericalHelper.GetLineEquation(x1, y1, x2, y2);
            (float a, float b) expected = (expectedA, expectedB);

            Assert.AreEqual(expected.a, actual.a, 0.001d);
            Assert.AreEqual(expected.b, actual.b, 0.001d);
        }

        [TestCase(4, 3, 4, 1)]
        public void GetLineEquation_WhenX1AndX2AreEqual_ShoudThrowArgumentException
            (float x1, float y1, float x2, float y2)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                NumericalHelper.GetLineEquation(x1, y1, x2, y2);
            });
        }

        [TestCase(22, 4)]
        [TestCase(-15, -6)]
        [TestCase(10, 1)]
        [TestCase(99, 18)]
        public void GetSummOfInputBySymbol_WhenInputEqualToTwoNumbers_ShouldReturnSumOfNumbers
            (int a, int expected)
        {
            int actual = NumericalHelper.GetSummOfInputBySymbol(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(333)]
        [TestCase(-245)]
        [TestCase(100)]
        [TestCase(-100)]
        [TestCase(9)]
        [TestCase(0)]
        public void GetSummOfInputBySymbol_WhenInputOutOfRange_ShouldThrowArgumentOutOfRangeException
            (int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                NumericalHelper.GetSummOfInputBySymbol(a);
            });
        }
    }
}
