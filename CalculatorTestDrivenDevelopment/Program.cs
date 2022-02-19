using System;

namespace CalculatorTestDrivenDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = CalculationOperations.DifferenceOfTwoNumbers(3, 0);
            Console.WriteLine(result);
        }
    }
}