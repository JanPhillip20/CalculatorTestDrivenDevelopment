using NUnit.Framework;
using CalculatorTestDrivenDevelopment;


namespace TestCalculatorTestDrivenDevelopment
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_AddTwoDoubleNumbers_InsertToPositivNumbers()
        {
            double firstNumber = 4.6;
            double secondNumber = 10;
            double resultExpected = 14.6;
            double resultActual = CalculationOperations.AddTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0);
        }

        [Test]
        public void Test_SubTwoDoubleNumbers_InsertTwoPositivNumbers()
        {
            double firstNumber = 20;
            double secondNumber = 10;
            double resultExpected = 10;
            double resultActual = CalculationOperations.SubTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0);
        }
        
        [Test]
        public void Test_MultiplyTwoDoubleNumbers_InsterTwoPositivNumbers()
        {
            double firstNumber = 5;
            double secondNumber = 10;
            double resultExpected = 50;
            double resultActual = CalculationOperations.MultiplyTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0);
        }
        
        [Test]
        public void Test_DifferenceOfTwoDoubleNumbers_InsertRegularNumbers()
        {
            double firstNumber = 5;
            double secondNumber = 10;
            double resultExpected = 0.5;
            double resultActual = CalculationOperations.DifferenceOfTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0);
        }
        [Test]
        public void Test_DifferenceOfTwoDoubleNumbers_InsertZeroAsSecondNumber()
        {
            double firstNumber = 5;
            double secondNumber = 0;
            double resultExpected = 0.0;
            double resultActual = CalculationOperations.DifferenceOfTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0.5);
        }
    }
}