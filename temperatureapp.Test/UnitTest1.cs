namespace temperatureapp.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void MyFirstTest()
    {

    }

    [Fact]
    public void TestIfTrueIsTrue()
    {
        Assert.True(true);
    }

    [Fact]
    public void TwoPlusTwoEqualsFour()
    {
        int result = 2 + 2;
        Assert.Equal(4, result);
    }

    [Fact]
    public void TwoPlusTwoEqualsFive()
    {
        int result = 2 + 2;
        Assert.NotEqual(5, result);
    }

    [Fact]
    public void CanAddNumbers()
    {
        //Arrange
        int num1 = 2;
        int num2 = 3;

        //Act
        int result = num1 + num2;

        //Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void CanCaulculateAverage()
    {
        //Arrange
        int[] numbers = {2, 3, 5, 7, 11};

        //Act
        double average = numbers.Average();

        //Assert
        Assert.Equal(5.6, average, 1);
    }

    [Theory]
    [InlineData(3, 7, 10)]
    [InlineData(-3, -7, -10)]
    [InlineData(100, 200, 300)]
    public void CanAddNumberParameterized(int num1, int num2, int expected)
    {
        //Assert

        //Act
        int result = num1 + num2;

        //Assert
        Assert.Equal(expected, result);
    }


}