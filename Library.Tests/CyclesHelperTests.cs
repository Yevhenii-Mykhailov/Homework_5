using System;
using NUnit.Framework;

namespace Library.Tests
{
    public class CyclesHelperTests
    {
        [TestCase(11, 0, 1)]
        [TestCase(5, 2, 25)]
        [TestCase(-3, 2, 9)]
        [TestCase(-3, 3, -27)]
        [TestCase(2, -4, 16d)]
        [TestCase(0, 2, 0)]
        [TestCase(0, -2, 0)]
        public void RaiseToThePower_WhenNumberAndPowerPassed_ShouldRaisToThePower
            (double number, double power, double expected)
        {
            double actual = CyclesHelper.RaiseToThePower(number, power);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(55, 7)]
        [TestCase(-38, 0)]
        [TestCase(0, 0)]
        [TestCase(16, 3)]
        [TestCase(17, 4)]
        [TestCase(18, 4)]
        public void GetLessSquareFromA_WhenAPassed_ShouldReturnLessSquareFromA
            (int a, int expected)
        {
            int actual = CyclesHelper.GetLessSquareFromA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 0)]
        [TestCase(75, 25)]
        [TestCase(765, 255)]
        [TestCase(10, 5)]
        [TestCase(9, 3)]
        [TestCase(8, 4)]
        public void GetLargestDivisorOfA_WhenAMoreThenZero_ShouldReturnLagestDivisior
            (int a, int expected)
        {
            int actual = CyclesHelper.GetLargestDivisorOfA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-43)]
        public void GetLargestDivisorOfA_WhenALessOrEqualToZero_ShouldThrowArgumentException
            (int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.GetLargestDivisorOfA(a);
            });
        }

        [TestCase(1, 8, 7)]
        [TestCase(1, 13, 7)]
        [TestCase(1, 14, 21)]
        [TestCase(1, 15, 21)]
        [TestCase(-30, 62, 182)]
        [TestCase(2, 3, 0)]
        [TestCase(-43, -7, -147)]
        public void GetSummOfRangeDivisibleBySeven_WhenAAndBPassed_ShouldReturnSumOfRangeDivisibleBySeven
            (int a, int b, int expected)
        {
            int actual = CyclesHelper.GetSummOfRangeDivisibleBySeven(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 8)]
        [TestCase(9, 34)]
        [TestCase(13, 233)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        public void GetElementOfFibboSeries_WhenInputMoreZero_ShouldReturnElementOfFibbo
            (int a, int expected)
        {
            int actual = CyclesHelper.GetElementOfFibboSeries(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5)]
        [TestCase(0)]
        public void GetElementOfFibboSeries_WhenInputLessOrEqualToZero_ShouldThrowArgumentException
            (int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.GetElementOfFibboSeries(a);
            });
        }

        [TestCase(2, 8, 2)]
        [TestCase(12, 32, 4)]
        [TestCase(35, 10, 5)]
        [TestCase(0, 11, 11)]
        public void GetGreatestDivisiorByEuclid_WhenInputPassed_ShoudReturnGreatestDivisior
            (int a, int b, int expected)
        {
            int actual = CyclesHelper.GetGreatestDivisiorByEuclid(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5, 22)]
        [TestCase(17, -8)]
        public void GetGreatestDivisiorByEuclid_WhenInputLessThenZero_ShouldThrowArgumentException
            (int a, int b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.GetGreatestDivisiorByEuclid(a, b);
            });
        }

        [TestCase(1728, 12)]
        [TestCase(729, 9)]
        [TestCase(9261, 21)]
        public void GetNumberByBinaryAlgorithm_WhenInputHasCubeRoot_ShouldReturnCubeRootByBinaryAlgorithm
            (int a, int expected)
        {
            int actual = CyclesHelper.GetNumberByBinaryAlgorithm(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-729)]
        [TestCase(0)]
        public void GetNumberByBinaryAlgorithm_WhenInputLessOrEqualToZero_ShouldThrowArgumentException
            (int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.GetNumberByBinaryAlgorithm(a);
            });
        }
                
        [TestCase(76)]
        public void GetNumberByBinaryAlgorithm_WhenInputHasNoCubeRoot_ShouldThrowFormatException
            (int a)
        {
            Assert.Throws<FormatException>(() =>
            {
                CyclesHelper.GetNumberByBinaryAlgorithm(a);
            });
        }

        [TestCase(8642, 0)]
        [TestCase(-987162, 3)]
        [TestCase(8712311, 5)]
        [TestCase(0, 0)]
        public void GetNumberOfOddDigits_WhenInputPassed_ShouldReturnNumberOfOddDigits
            (int a, int expected)
        {
            int actual = CyclesHelper.GetNumberOfOddDigits(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8642, 2468)]
        [TestCase(-987162, -261789)]
        [TestCase(8712311, 1132178)]
        [TestCase(0, 0)]
        [TestCase(1200, 21)]
        public void ReverseNumber_WhenInputPassed_ShouldReturnReversedNumber
            (int a, int expected)
        {
            int actual = CyclesHelper.ReverseNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8642, 2468, true)]
        [TestCase(-987162, -7623, true)]
        [TestCase(12345, 67890, false)]
        [TestCase(0, 0, true)]
        public void VerifySameDigits_WhenInputPassed_ShouldReturnTrueOrFalse
            (int a, int b, bool expected)
        {
            bool actual = CyclesHelper.VerifySameDigits(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}

