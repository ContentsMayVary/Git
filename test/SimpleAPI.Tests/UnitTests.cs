using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTests
{
    [Fact]
    public void GetData_with_param_returns_param()
    {
        for (int i = 1; i <= 5; ++i)
        {
            var actual = _controller.GetData(i);
            Assert.Equal(i, actual);
        }
    }

    [Fact]
    public void GetData_returns_my_name()
    {
        var actual = _controller.GetData();
        Assert.Equal("Matthew Watson", actual);
    }

    readonly SimpleController _controller = new();
}