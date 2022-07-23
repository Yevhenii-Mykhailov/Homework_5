using System;
using NUnit.Framework;

namespace Library.Tests
{
    public class ArrayMatrixHelperTests
    {
         private static object[] DataForMinIndex =
        {
            new object[]
            {
                new[,]
                {
                    { 1, 2},
                    { -7, 3},
                    { 11, 4}
                },
                1, 0
            },
            new object[]
            {
                new[,]
                {
                    { 5, 14, 1},
                    { 3, 4, 0},
                    { 2, 8 , 9}
                },
                1, 2 
            },
            new object[]
            {
                new[,]
                {
                    { -6, -8, -9, 0},
                    { -3, -11, -2, -3},
                    { -7, -5, -18, -7}
                },
                2, 2
            },
            new object[]
            {
                new[,]
                {
                    { 5, 8, 11, 0},
                    { 3, 0, 2, 3},
                    { 7, 5, 0, 7}
                },
                0, 3
            },
        };

        [TestCaseSource(nameof(DataForMinIndex))]
        public void GetMinElementIndex_WhenMatrixFilled_GetFirstMinElementIndex
            (int [,] matrix, int expectedA, int expectedB)
        {
            (int a, int b) actual = ArrayMatrixHelper.GetMinElementIndex(matrix);
            (int a, int b) expected = (expectedA, expectedB);

            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForEmptyMatrix =
        {
            new object[]
            {
                new int[,]
                {
                },
            }
        };

        [TestCase(null)]
        [TestCaseSource(nameof(DataForEmptyMatrix))]
        public void GetMinElementIndex_WhenMatrixNullOrEmpty_ShouldThrowArgumentException
            (int [,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayMatrixHelper.GetMinElementIndex(matrix);
            });
        }

        private static object[] DataForMaxIndex =
        {
            new object[]
            {
                new[,]
                {
                    { 1, 2},
                    { 5, 3},
                    { 7, 0}
                },
                2, 0
            },
            new object[]
            {
                new[,]
                {
                    { 5, 14, 1},
                    { 3, 4, 0},
                    { 14, 8 , 9}
                },
                0, 1
            },
            new object[]
            {
                new[,]
                {
                    { -6, -8, -9, -5},
                    { -3, -11, -2, -3},
                    { -7, -5, -18, -7}
                },
                1, 2
            },
        };

        [TestCaseSource(nameof(DataForMaxIndex))]
        public void GetMaxElementIndex_WhenMatrixFilled_GetFirstMaxElementIndex
            (int[,] matrix, int expectedA, int expectedB)
        {
            (int a, int b) actual = ArrayMatrixHelper.GetMaxElementIndex(matrix);
            (int a, int b) expected = (expectedA, expectedB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCaseSource(nameof(DataForEmptyMatrix))]
        public void GetMaxElementIndex_WhenMatrixNullOrEmpty_ShouldThrowArgumentException
            (int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayMatrixHelper.GetMaxElementIndex(matrix);
            });
        }

        private static object[] DataForMinElementOfMatrix =
        {
            new object[]
            {
                new[,]
                {
                    { 1, 2},
                    { 5, 0},
                    { 7, 9}
                },
                0
            },
            new object[]
            {
                new[,]
                {
                    { 5, 14, 4},
                    { 3, 4, 3},
                    { 14, 8 , 9}
                },
                3
            },
            new object[]
            {
                new[,]
                {
                    { -6, -8, -18, -5},
                    { -3, -11, 0, -3},
                    { -7, 0, -18, -7}
                },
                -18
            },
        };

        [TestCaseSource(nameof(DataForMinElementOfMatrix))]
        public void GetMinElementOfMatrix_WhenMatrixFilled_GetFirstMinElement
            (int[,] matrix, int expected)
        {
            int actual = ArrayMatrixHelper.GetMinElementOfMatrix(matrix);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCaseSource(nameof(DataForEmptyMatrix))]
        public void GetMinElementOfMatrix_WhenMatrixNullOrEmpty_ShouldThrowArgumentException
            (int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayMatrixHelper.GetMinElementOfMatrix(matrix);
            });
        }

        private static object[] DataForMaxElementOfMatrix =
        {
            new object[]
            {
                new[,]
                {
                    { 1, 2},
                    { 5, 0},
                    { 7, 9}
                },
                9
            },
            new object[]
            {
                new[,]
                {
                    { 5, 14, 4},
                    { 3, 4, 14},
                    { 14, 8 , 9}
                },
                14
            },
            new object[]
            {
                new[,]
                {
                    { -6, -8, -18, -5},
                    { -3, -11, 0, -3},
                    { -7, 0, -18, -7}
                },
                0
            },
        };

        [TestCaseSource(nameof(DataForMaxElementOfMatrix))]
        public void GetMaxElementOfMatrix_WhenMatrixFilled_GetFirstMaxElement
            (int[,] matrix, int expected)
        {
            int actual = ArrayMatrixHelper.GetMaxElementOfMatrix(matrix);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCaseSource(nameof(DataForEmptyMatrix))]
        public void GetMaxElementOfMatrix_WhenMatrixNullOrEmpty_ShouldThrowArgumentException
            (int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayMatrixHelper.GetMaxElementOfMatrix(matrix);
            });
        }

        private static object[] DataForFlipMatrix =
        {
            new object[]
            {
                new[,]
                {
                    { 1, 2, 4},
                    { 5, 0, 3},
                    { 7, 9, 8}
                },
                new[,]
                {
                    { 1, 9, 7},
                    { 3, 0, 5},
                    { 4, 2, 8}
                },
            },
            new object[]
            {
                new[,]
                {
                    { 5, 14, 4, 11},
                    { 3, 4, 14, 43},
                    { 14, 8, 9, -7},
                    { 12, 2, 1, 0}
                },
                new[,]
                {
                    { 5, 1, 2, 12},
                    { -7, 4, 8, 14},
                    { 43, 14, 9, 3},
                    { 11, 4, 14, 0}
                },
            },
            new object[]
            {
                new[,]
                {
                    { 5, 14, 4, 11},
                    { 3, 4, 14, 43},
                    { 14, 8, 9, -7},
                },
                new[,]
                {
                    { 5, 9, 8, 14},
                    { 43, 4, 4, 3},
                    { 11, 4, 9, 5},
                },
            },
            new object[]
            {
                new[,]
                {
                    { 5, 1, 2},
                    { -7, 4, 8},
                    { 43, 14, 9},
                    { 11, 4, 14},
                    { 12, 2, 1}
                },
                new[,]
                {
                    { 5, 2, 12},
                    { 14, 4, 11},
                    { 9, 14, 9},
                    { 8, 4, -7},
                    { 2, 1, 5}
                },
            },
        };

        [TestCaseSource(nameof(DataForFlipMatrix))]
        public void FlippMatrixAboutItsMainDiagonal_WhenMatrixFilled_ShouldFlippMatrixAboutItsMainDiagonal
            (int[,] matrix, int[,] expected)
        {
            int[,] actual = ArrayMatrixHelper.FlippMatrixAboutItsMainDiagonal(matrix);

            CollectionAssert.AreEqual(expected, actual);
        }

        private static object[] DataForEmptyAndIncorrectFlippMatrix =
        {
            new object[]
            {
                new int[,]
                {

                },
            },
            new object[]
            {
                new int[,]
                {
                    { 1, 2, 3 }
                },
            },
            new object[]
            {
                new int[,]
                {
                    { 1 },
                    { 2 },
                    { 3 }
                },
            }
        };

        [TestCase(null)]
        [TestCaseSource(nameof(DataForEmptyAndIncorrectFlippMatrix))]
        public void FlippMatrixAboutItsMainDiagonal_WhenMatrixNullOrEmptyOrIncorrect_ShouldThrowArgumentException
            (int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayMatrixHelper.FlippMatrixAboutItsMainDiagonal(matrix);
            });
        }
    }
}

