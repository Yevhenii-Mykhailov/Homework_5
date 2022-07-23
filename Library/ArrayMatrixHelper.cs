using System;

namespace Library
{
    public class ArrayMatrixHelper
    {
        public static int GetMinElementOfMatrix(int[,] array )
        {
            (int minRow, int minCol) = GetMinElementIndex(array);
            return array[minRow, minCol];
        }

        public static int GetMaxElementOfMatrix(int[,] array)
        {
            (int maxRow, int maxCol) = GetMaxElementIndex(array);
            return array[maxRow, maxCol];
        }

        public static (int minRow, int minCol) GetMinElementIndex(int [,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }

            int minRow = 0;
            int minCol = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[minRow, minCol] > array[i, j])
                    {
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            return (minRow, minCol);
        }

        public static (int maxRow, int maxCol) GetMaxElementIndex(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }

            int maxRow = 0;
            int maxCol = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[maxRow, maxCol] < array[i, j])
                    {
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            return (maxRow, maxCol);
        }

        public static int[,] FlippMatrixAboutItsMainDiagonal(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0
                || matrix.GetLength(0) == 1 || matrix.GetLength(1) == 1)
            {
                throw new ArgumentException();
            }

            int[,] flippedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        flippedMatrix[i, j] = matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - 1 - j];
                    }
                    else
                    {
                        flippedMatrix[i, j] = matrix[i, j];
                    }
                }
            }

            return flippedMatrix;
        }

        //test
        public static int FindTheNumberThatAreGreaterThanAllTheirNeighbors(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix");
            }

            int maxValue = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int temp = 0;

                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        if (k >= 0 && k <= matrix.GetLength(0) - 1)
                        {
                            for (int o = j - 1; o <= j + 1; o++)
                            {
                                if (o >= 0 && o <= matrix.GetLength(1) - 1 && (k != i || o != j))
                                {
                                    if (temp < matrix[k, o])
                                    {
                                        temp = matrix[k, o];
                                    }
                                }
                            }
                        }
                    }

                    if (matrix[i, j] > temp)
                    {
                        maxValue++;
                    }
                }
            }

            return maxValue;
        }
    }
}

