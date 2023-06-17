using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 2, 3, 6)]
        [InlineData(0, -1, -2, -3)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator test = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = test.Add(num1, num2, num3);
            Assert.Equal(expected, actual);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(13, 4, 9)]//Add test data <-------
        [InlineData(0, 4, -4)]
        [InlineData(0, -4, 4)]
        [InlineData(-3, 0, -3)]
        [InlineData(-3, -6, 3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator test = new Calculator();

            //Act
            int actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 4, 12)]//Add test data <-------
        [InlineData(0, 4, 0)]
        [InlineData(0, -4, 0)]
        [InlineData(-3, 0, 0)]
        [InlineData(3, 0, 0)]
        [InlineData(-3, -3, 9)]
        [InlineData(-3, 3, -9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator test = new Calculator();

            //Act
            int actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(12, 4, 3)]//Add test data <-------
        [InlineData(0, 4, 0)]
        [InlineData(0, -4, 0)]
        [InlineData(-3, 0, 0)]
        [InlineData(3, 0, 0)]
        [InlineData(-3, -3, 1)]
        [InlineData(-3, 3, -1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator test = new Calculator();

            //Act
            int actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}