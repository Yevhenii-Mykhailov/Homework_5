using System;
using NUnit.Framework;

namespace Library.Tests
{
    public class CalculationHelperTests
    {
        [TestCase(2, 7, -5)]
        [TestCase(8, 3, 11)]
        [TestCase(8, 8, 64)]
        [TestCase(-5, -8, -13)]
        [TestCase(0, 0, 0)]
        public void GetCalcutaionResults_WhenAAndBPassed_ShouldReturnCalculationResult
            (int a, int b, int expected)
        {
            int actual = CalculationHelper.GetCalcutaionResults(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1)]
        [TestCase(8, -3, 4)]
        [TestCase(-10, 5, 2)]
        [TestCase(-10, -3, 3)]
        public void DetermineQuaterOfEnteredCoords_WhenXYNotZero_ShouldGetQuater
            (int x, int y, int expected)
        {
            var actual = CalculationHelper.DetermineQuaterOfEnteredCoords(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 0)]
        [TestCase(0, 0)]
        public void DetermineQuaterOfEnteredCoords_WhenXOrYIsZero_ShouldThrowArgumentException
            (int x, int y)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CalculationHelper.DetermineQuaterOfEnteredCoords(x, y);
            });
        }

        [TestCase(0, 9, 5, 0, 5, 9)]
        [TestCase(11, -4, 2, -4, 2, 11)]
        [TestCase(-8, -12, -40, -40, -12, -8)]
        [TestCase(0, 5, 0, 0, 0, 5)]
        [TestCase(7, 0, -5, -5, 0, 7)]
        public void PrintAscendingOrder_WhenABCPassed_ShoudPrintABCInAscendingOrder
            (int a, int b, int c,
             int expectedA, int expectedB, int expectedC)
        {
            (int a, int b, int c) actual = CalculationHelper.PrintAscendingOrder(a, b, c);
            (int a, int b, int c) expected = (expectedA, expectedB, expectedC);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, -3, 0.5d, -3)]
        [TestCase(2, 6, 0, 0, -3)]
        [TestCase(5, -6, 1, 1, 0.2d)]
        public void GetRootsOfQuadraticEquation_WhenABCPassed_ShoudReturnRootsOfQuadraticEquation
            (float a, float b, float c, double expectedX1, double expectedX2)
        {
            (double x1, double x2) actual = CalculationHelper.GetRootsOfQuadraticEquation(a, b, c);
            (double x1, double x2) expected = (expectedX1, expectedX2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 2, 2)]
        [TestCase(5, 3, 3)]
        public void GetRootsOfQuadraticEquation_WhenDiscriminantLessThenZero_ShoudThrowArgumentException
            (float a, float b, float c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CalculationHelper.GetRootsOfQuadraticEquation(a, b, c);
            });
        }

        [TestCase(0, 2, 2)]
        public void GetRootsOfQuadraticEquation_WhenAIsEqualToZero_ShoudThrowArgumentException
            (float a, float b, float c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CalculationHelper.GetRootsOfQuadraticEquation(a, b, c);
            });
        }

        [TestCase(10, "Ten")]
        [TestCase(11, "Eleven")]
        [TestCase(12, "Twelve")]
        [TestCase(13, "Thirteen")]
        [TestCase(14, "Fourteen")]
        [TestCase(15, "Fifteen")]
        [TestCase(16, "Sixteen")]
        [TestCase(17, "Seventeen")]
        [TestCase(18, "Eighteen")]
        [TestCase(19, "Nineteen")]
        [TestCase(20, "Twenty")]
        [TestCase(30, "Thirty")]
        [TestCase(40, "Fourty")]
        [TestCase(50, "Fifty")]
        [TestCase(60, "Sixty")]
        [TestCase(70, "Seventy")]
        [TestCase(80, "Eighty")]
        [TestCase(90, "Ninety")]
        [TestCase(94, "NinetyFour")]
        [TestCase(87, "EightySeven")]
        [TestCase(73, "SeventyThree")]
        [TestCase(65, "SixtyFive")]
        [TestCase(52, "FiftyTwo")]
        [TestCase(41, "FourtyOne")]
        [TestCase(38, "ThirtyEight")]
        [TestCase(29, "TwentyNine")]
        public void PrintNumberCapitalization_WhenInputPassed_ShouldReturnNumberCapitapization
            (int a, string expected)
        {
            string actual = CalculationHelper.PrintNumberCapitalization(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(123)]
        public void PrintNumberCapitalization_WhenInputMoreThenNintyNineAndLessOrEqualToZero_ShouldThrowArgumentException
            (int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CalculationHelper.PrintNumberCapitalization(a);
            });
        }
    }
}

