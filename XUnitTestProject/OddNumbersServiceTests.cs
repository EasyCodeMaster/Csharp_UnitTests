using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject
{
    public class OddNumbersServiceTests
    {
        [Fact]
        public void IsOddMethod_OddNubers_ReturnTrue()
        {
            var service = new OddNumbersService();

            var result = service.IsOdd(3);
            
            Assert.True(result);
        }

        [Fact]
        public void IsOddMethod_OddNubers_ReturnFalse()
        {
            var service = new OddNumbersService();

            var result = service.IsOdd(4);

            Assert.False(result);
        }

        [Fact]
        public void IsEvenMethod_EvenNubers_ReturnTrue()
        {
            var service = new OddNumbersService();

            var result = service.IsEven(4);

            Assert.True(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(9)]
        //[InlineData(2)]
        public void IsOddMethod_EvenNubers_ReturnFalse(int number)
        {
            // * naming: TestedUnit_Conditions_ExpectedResult
            // Arrange: Describe the phase where we initialize everything need in test
            var service = new OddNumbersService();

            // Act: Call the part need to be tested
            var result = service.IsEven(number);

            // Assert: Check the result
            Assert.False(result);
        }
    }
}
