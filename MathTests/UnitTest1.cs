using System;
using Xunit;
using Math;

namespace MathTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var atual = Class1.Add(1,3);
        Assert.True(atual == 4);
    }

     [Fact]
    public void Test2()
    {
        var atual = Class1.Add(1,3);
        Assert.True(atual == 3);
    }
}