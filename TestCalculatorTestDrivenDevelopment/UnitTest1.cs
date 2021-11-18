using NUnit.Framework;
using CalculatorTestDrivenDevelopment;


namespace TestCalculatorTestDrivenDevelopment
{
    public class Tests
    {
        private CalculationOperations _calculationOperations;
        [SetUp]
        public void Setup()
        {
            _calculationOperations = new CalculationOperations();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_AddTwoDoubleNumbers()
        {
            double firstNumber = 4.6;
            double secondNumber = 10;
            double resultExpected = 14.6;
            double resultActual = _calculationOperations.addTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0);
        }

        [Test]
        public void Test_SubTwoDoubleNumbers()
        {
            double firstNumber = 20;
            double secondNumber = 10;
            double resultExpected = 10;
            double resultActual = _calculationOperations.subTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0);
        }
        
        [Test]
        public void Test_MultiplyTwoDoubleNumbers()
        {
            double firstNumber = 5;
            double secondNumber = 10;
            double resultExpected = 50;
            double resultActual = _calculationOperations.multiplyTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0);
        }
        
        [Test]
        public void Test_DifferenceOfTwoDoubleNumbers()
        {
            double firstNumber = 5;
            double secondNumber = 10;
            double resultExpected = 0.5;
            double resultActual = _calculationOperations.differenceOfTwoNumbers(firstNumber, secondNumber);
            Assert.AreEqual(resultExpected, resultActual, 0);
        }
    }
}