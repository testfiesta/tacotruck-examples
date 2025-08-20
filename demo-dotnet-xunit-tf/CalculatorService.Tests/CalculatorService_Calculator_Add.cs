using System;
using CalculatorService;

namespace CalculatorService.Tests;

public class CalculatorService_Calculator_Add
{
    readonly Calculator _calculator = new();

    [Theory]
    [InlineData(2, 1, 3)]
    [InlineData(5, 3, 8)]
    public void Calculator_Adds_TwoPositiveNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = _calculator.Add(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-2, -3, -5)]
    [InlineData(-10, -6, -16)]
    public void Calculator_Adds_TwoNegativeNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = _calculator.Add(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-5, 10, 5.0d)]
    [InlineData(-10.4, 6.3, -4.0d)]
    public void Calculator_Adds_MixedNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = Math.Ceiling(_calculator.Add(a, b));

        Assert.Equal(expected, result);
    }


    [Fact]
    public void Calculator_Adds_Two_Zeroes_And_ReturnsSum()
    {
        var result = _calculator.Add(0, 0);

        Assert.Equal(0, result);
    }
}
