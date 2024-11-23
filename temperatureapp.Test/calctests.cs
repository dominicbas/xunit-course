using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
namespace temperatureapp.Test
{
    public class CalcTests : IDisposable
    {
        private Calculator calc;
        public CalcTests()
        {
            calc = new Calculator();

        }
        [Fact]
        public void AddTwoIntergers()
        {
            //Arrange 
            //var calc = new Calculator();
        
            //Act 
            var result = calc.Add(1, 2);

            //Assert 
            Assert.Equal(3, result);
        }

        [Fact]
        public void SubstractTwoIntergers()
        {

        

        //Arrange
        //var calc = new Calculator();

        //Act
        var result = calc.Substract(3, 2);

        //Assert
        Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(new int[] {1, 2, 3}, 6)]
        [InlineData(new int[] {4, 5, 6}, 15)]

        public void AddMultipleIntergers(int[] numbers, int expected)
        {
            //Arrange
            //var calc = new Calculator();

            //Act 
            var result = calc.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] {5, 2, 1}, 12)]
        [InlineData(new int[] {10, 5, 2}, 3)]
        public void SubstractMultipleIntergers(int[] numbers, int expected)
        {

        //Arrange
        //var calc = new Calculator();

        //Act
        var result = calc.Substract(numbers);

        //Assert
        Assert.Equal(expected, result);
        }

        [Fact]
        public void AddAndStoreInHistory()
        {
            //Arrange
            //var calc = new Calculator();
        
            //Act
            var result1 = calc.Add(1,2,3); //6
            var result2 = calc.Add(4,5,6); //15
        
            //Assert
            Assert.Equal(2, calc.History.Count);
            Assert.Equal(result1, calc.History[0]);
            Assert.Equal(result2, calc.History[1]);
        }

        [Fact]
        public void StoreInHistory()
        {
            //Arrange
            
            //Act
            var result1 = calc.Add(1, 2, 3); //6
            var result2 = calc.Add(4, 5, 6); //15



            //Assert again
            Assert.Equal(2, calc.History.Count);
            Assert.Equal(result1, calc.History[0]);
            Assert.Equal(result2, calc.History[1]);

        }
        public void Dispose()
        {

        }











    }


}