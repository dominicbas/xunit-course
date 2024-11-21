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


}