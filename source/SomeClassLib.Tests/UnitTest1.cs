namespace SomeClassLib.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello, John", Class1.Greet("John"));
    }
}
