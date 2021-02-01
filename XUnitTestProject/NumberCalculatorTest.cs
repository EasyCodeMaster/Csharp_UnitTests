using System;
using Xunit;

namespace XUnitTestProject
{
    public class NumberCalculatorTest
    {
        [Fact]
        public void AddMethod_Success()
        {
            var calculator = new NumbersCalculator();

            var result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void SubtractMethod_Success()
        {
            var calculator = new NumbersCalculator();

            var result = calculator.Subtract(5, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void MultiplicationMethod_Success()
        {
            var calculator = new NumbersCalculator();

            var result = calculator.Multiplication(1, 2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void DivisionMethod_Success()
        {
            var calculator = new NumbersCalculator();

            var result = calculator.Multiplication(5, 1);

            Assert.Equal(5, result);
        }

        [Fact]
        public void SubtractMethod_ReverseInput_Success()
        {
            var calculator = new NumbersCalculator();

            var result = calculator.Subtract(1, 5);

            Assert.Equal(0, result);
        }
    }
}
