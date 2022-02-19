using System;

namespace CalculatorTestDrivenDevelopment
{
    public static class CalculationOperations
    {
        public static double AddTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double SubTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double MultiplyTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double DifferenceOfTwoNumbers(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
                return firstNumber / secondNumber;
            return 0.0;
        }

    }
}