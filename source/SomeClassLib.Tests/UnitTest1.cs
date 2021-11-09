namespace SomeClassLib.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello, John", Class1.Greet("John"));
    }

    [Fact]
    public void FailIt()
    {
        Assert.Equal("Hello, Dork", Class1.Greet("John"));
    }
}
