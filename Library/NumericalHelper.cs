using System;

namespace Library
{
    public class NumericalHelper
    {
        public static int ConvertHoursToMinutes(int hours)
        {
            if (hours <= 0)
            {
                throw new ArgumentException("Hours cannot be less or equal to zero!");
            }

            return hours * 60;
        }

        public static float CalculateFormula(int a, int b)
        {
            if ((b - a) == 0)
            {
                throw new ArgumentException("Cannot delete on zero!");
            }

            return (float)(5 * a + b * b) / (b - a);
        }

        public static (int a, int b) SwapValues(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return (a, b);
        }

        public static (double dividing, double divisionRemainder) CalculateDividingAndDivisionRemainder(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot delete on zero!");
            }

            double dividing = a / b;
            double divisionRemainder = a % b;

            return (dividing, divisionRemainder);
        }

        public static double CalculateExpressionByFormula(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Cannot delete on zero!");
            }

            return c - b / a;
        }

        public static (float a, float b) GetLineEquation(float x1, float y1, float x2, float y2)
        {
            if ((x1 - x2) == 0)
            {
                throw new ArgumentException("Cannot delete on zero!");
            }

            float a = (y1 - y2) / (x1 - x2);
            float b = y2 - a * x2;

            return (a, b);
        }

        public static int GetSummOfInputBySymbol(int userValue)
        {
            int firstNumber = userValue / 10;
            int secondNumber = userValue % 10;

            if (firstNumber <= -10 || firstNumber >= 10 || firstNumber == 0)
            {
                throw new ArgumentException();
            }

            return firstNumber + secondNumber;
        }
    }
}