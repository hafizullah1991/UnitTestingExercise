using System;
using Xunit;
using UnitTestingExercise;
using System.Runtime.InteropServices;
namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator instance = new Calculator();
           

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
        var actual =  instance.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2,1)]//Add test data <-------
        [InlineData(4,2, 2)]
        [InlineData(10,2, 8)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator instance = new Calculator();

            //Act
          int actual =   instance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,1)]//Add test data <-------
        [InlineData(1 , 0, 0)]
        [InlineData(2,3, 6)]
        [InlineData(0, 0 , 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator instance = new Calculator();

            //Act
         int actual =    instance.Mutiply(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 5, 2)]//Add test data <-------
        [InlineData(5 , 5, 1)]
        [InlineData(5, 0 ,null)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();

            //Act
          int actual =  instance.Devide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

    }
}
