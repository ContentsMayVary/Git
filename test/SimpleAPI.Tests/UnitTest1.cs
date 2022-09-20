using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void GetData_returns_my_name()
    {
        var actual = _controller.GetData();
        Assert.Equal("Matthew Watson", actual);
    }

    readonly SimpleController _controller = new();
}