using System;

namespace Library
{
    public class CalculationHelper
    {
        public static int GetCalcutaionResults(int a, int b)
        {
            int result = a;

            if (a > b)
            {
                result += b;
            }
            else if (a == b)
            {
                result *= b;
            }
            else
            {
                result -= b;
            }

            return result;
        }

        public static int DetermineQuaterOfEnteredCoords(int x, int y)
        {

            if (x == 0 || y == 0)
            {
                throw new ArgumentException("Coords has to be more than zero!");
            }

            int result;

            if (x > 0)
            {
                if (y > 0)
                {
                    result = 1;
                }
                else
                {
                    result = 4;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }

            return result;
        }

        public static (int min, int medium, int high) PrintAscendingOrder(int a, int b, int c)
        {
            if (a > b)
            {
                Swap(ref a, ref b);
            }

            if (a > c)
            {
                Swap(ref a, ref c);
            }

            if (b > c)
            {
                Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        public static (double x1, double x2) GetRootsOfQuadraticEquation(float a, float b, float c)
        {
            double x1 = double.NaN;
            double x2 = double.NaN;
            double sqrtOfDiscriminant = Math.Sqrt((b * b) - (4 * a * c));

            if (a == 0)
            {
                throw new ArgumentException();
            }

            if (double.IsNaN(sqrtOfDiscriminant))
            {
                throw new ArgumentException("Discriminant cannot be less then zero!");
            }

            if (sqrtOfDiscriminant >= 0)
            {
                x1 = (-b + sqrtOfDiscriminant) / (2 * a);
                x2 = (-b - sqrtOfDiscriminant) / (2 * a);
            }

            return (x1, x2);
        }

        public static string PrintNumberCapitalization(int userInput)
        {
            int firstNumber = userInput / 10;
            int secondNumber = userInput % 10;

            if (firstNumber >= 10 || userInput <= 0)
            {
                throw new ArgumentException("Input is out of range!");
            }

            if (firstNumber != 1)
            {
                return GetDozens(firstNumber) + GetUnits(secondNumber);
            }
            else
            {
                return GetExeptionalNumbers(secondNumber);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static string GetDozens(int firstNumber)
        {
            string result = string.Empty;
            switch (firstNumber)
            {
                case 2:
                    result = "Twenty";
                    break;
                case 3:
                    result = "Thirty";
                    break;
                case 4:
                    result = "Fourty";
                    break;
                case 5:
                    result = "Fifty";
                    break;
                case 6:
                    result = "Sixty";
                    break;
                case 7:
                    result = "Seventy";
                    break;
                case 8:
                    result = "Eighty";
                    break;
                case 9:
                    result = "Ninety";
                    break;
            }

            return result;
        }

        private static string GetUnits(int secondNumber)
        {
            string result = string.Empty;
            switch (secondNumber)
            {
                case 1:
                    result = "One";
                    break;
                case 2:
                    result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                case 4:
                    result = "Four";
                    break;
                case 5:
                    result = "Five";
                    break;
                case 6:
                    result = "Six";
                    break;
                case 7:
                    result = "Seven";
                    break;
                case 8:
                    result = "Eight";
                    break;
                case 9:
                    result = "Nine";
                    break;
            }

            return result;
        }

        private static string GetExeptionalNumbers(int secondNumber)
        {
            string result = string.Empty;
            switch (secondNumber)
            {
                case 0:
                    result = "Ten";
                    break;
                case 1:
                    result = "Eleven";
                    break;
                case 2:
                    result = "Twelve";
                    break;
                case 3:
                    result = "Thirteen";
                    break;
                case 4:
                    result = "Fourteen";
                    break;
                case 5:
                    result = "Fifteen";
                    break;
                case 6:
                    result = "Sixteen";
                    break;
                case 7:
                    result = "Seventeen";
                    break;
                case 8:
                    result = "Eighteen";
                    break;
                case 9:
                    result = "Nineteen";
                    break;
            }

            return result;
        }
    }
}

