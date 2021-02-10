using System;
using Xunit;

namespace tdd.tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldNotOutputFizzIfInputIsNotThree()
        {
            //Arrange
            //init
            var calculator = new Calculator();

            //Act
            var output = calculator.DetermineOutputBaseOnMultiple(5);

            //Assert
            Assert.NotEqual("fizz", output);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ShouldOutputFizzIfInputIsMultipleOfThree(int input)
        {
            //Arrange
            //init
            var calculator = new Calculator();

            //Act
            var output = calculator.DetermineOutputBaseOnMultiple(input);

            //Assert
            Assert.Equal("fizz", output);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldOutputBuzzIfInputIsMultipleOfFive(int input)
        {
            //Arrange
            //init
            var calculator = new Calculator();

            //Act
            var output = calculator.DetermineOutputBaseOnMultiple(input);

            //Assert
            Assert.Equal("buzz", output);
        }

        [Fact]
        public void ShouldNotOutputBuzzIfInputIsOne()
        {
            //Arrange
            //init
            var calculator = new Calculator();

            //Act
            var output = calculator.DetermineOutputBaseOnMultiple(1);

            //Assert
            Assert.NotEqual("buzz", output);
        }
    }
}
