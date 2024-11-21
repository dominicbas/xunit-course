using System;
using Microsoft.VisualBasic;
namespace temperatureapp.Test
{
    public class CalcTests
    {
        public CalcTests()
        {

        }
        [Fact]
        public void AddTwoIntergers()
        {
            //Arrange 
            var calc = new Calculator();
        
            //Act 
            var result = calc.Add(1, 2);

            //Assert 
            Assert.Equal(3, result);
        }

        [Fact]
        public void SubstractTwoIntergers()
        {

        

        //Arrange
        var calc = new Calculator();

        //Act
        var result = calc.Substract(3, 2);

        //Assert
        Assert.Equal(1, result);
        }





    }


}