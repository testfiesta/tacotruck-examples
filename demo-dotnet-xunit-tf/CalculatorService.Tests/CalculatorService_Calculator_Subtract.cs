using System;
using CalculatorService;

namespace CalculatorService.Tests;

public class CalculatorService_Calculator_Subtract
{
    readonly Calculator _calculator = new();

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 3, 2)]
    public void Calculator_Subtracts_TwoPositiveNumbers_And_ReturnsDifference(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-2, -3, 1)]
    [InlineData(-10, -6, -4.0d)]
    public void Calculator_Subtracts_TwoNegativeNumbers_And_ReturnsDifference(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-5, 10, -15.0d)]
    [InlineData(-10.4, 6.3, -16.0d)]
    public void Calculator_Subtracts_MixedNumbers_And_ReturnsDifference(double a, double b, double expected)
    {
        var result = Math.Ceiling(_calculator.Subtract(a, b));

        Assert.Equal(expected, result);
    }


    [Fact]
    public void Calculator_Subtracts_Two_Zeroes_And_ReturnsZero()
    {
        var result = _calculator.Subtract(0, 0);

        Assert.Equal(0, result);
    }
}
