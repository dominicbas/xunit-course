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

    [Fact]
    public void testFalse()
    {
        //Arrange
        bool condition = false;

        //Assert
        Assert.False(condition);
    }

    [Fact]
    public void TestNull()
    {
        //Arrange
        object obj = null;
    
    
        //Assert
        Assert.Null(obj);
    }

    [Fact]
    public void TestNotNull()
    {
        //Arrange
        object obj = new object();
    
    
        //Assert
        Assert.NotNull(obj);

    }

    [Fact]
    public void TestContains()
    {
        //Arrange
        List<int> collection = new List<int> {42};

        //Assert
        Assert.Contains(42, collection); 
    }

    [Fact]
    public void TestInRange()
    {
        //Arrange
        int actual = 5;
    
        //Assert
        Assert.InRange(actual, 0, 10);
    
    }

    [Fact]
    public void TestEmpty()
    {
        // Arrange
        List<int> collection = new List<int>();
    
    
        //Assert
        Assert.Empty(collection);
    }

    [Fact]
    public void TestNotEmpty()
    {
        //Arrange
        List<int> collection = new List<int> {1};
    
        //Assert
        Assert.NotEmpty(collection);
    }


}