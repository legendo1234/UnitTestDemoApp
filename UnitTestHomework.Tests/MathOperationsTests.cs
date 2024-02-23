using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHomework.Tests
{
    public class MathOperationsTests
    {
        [Theory]
        [InlineData(1, 1, 2)]


        public void AdditionShouldReturnExpectedValues(int number1, int number2, int expected)
        {
            //Arrange
            MathOperations mathOperations = new MathOperations();

            //Act
            int actual = mathOperations.Addition(number1, number2);

            //Assert
            Assert.Equal(expected,actual);
        }


        [Theory]
        [InlineData(1, 1, 0)]
        public void SubtractionShouldReturnExpectedValues(int number1, int number2, int expected)
        {
            //Arrange
            MathOperations mathOperations = new MathOperations();

            //Act
            int actual = mathOperations.Subtraction(number1, number2);

            //Assert
            Assert.Equal(expected,actual);
        }


        [Theory]
        [InlineData(4, 2, 8)]
        public void MultiplicationShouldReturnExpectedValues(int number1, int number2, int expected)
        {
            //Arrange
            MathOperations mathOperations = new MathOperations();

            //Act
            int actual = mathOperations.Multiplication(number1, number2);

            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        public void DivisionShouldReturnExpectedValues(int number1, int number2, int expected)
        {
            //Arrange
            MathOperations mathOperations = new MathOperations();

            //Act
            int actual = mathOperations.Division(number1, number2);

            //Assert
            Assert.Equal(expected,actual);
        }
    }
}
