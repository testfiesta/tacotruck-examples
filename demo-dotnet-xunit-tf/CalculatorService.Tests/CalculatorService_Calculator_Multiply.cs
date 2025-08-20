using System;
using CalculatorService;

namespace CalculatorService.Tests;

public class CalculatorService_Calculator_Multiply
{
    readonly Calculator _calculator = new();

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(5, 3, 15)]
    public void Calculator_Multiplies_TwoPositiveNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-2, -3, 6)]
    [InlineData(-10, -6, 60.0d)]
    public void Calculator_Multiplies_TwoNegativeNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-5, 10, -50.0d)]
    [InlineData(-10.4, 6.3, -65.0d)]
    public void Calculator_Multiplies_MixedNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = Math.Ceiling(_calculator.Multiply(a, b));

        Assert.Equal(expected, result);
    }


    [Fact]
    public void Calculator_Multiplies_Two_Zeroes_And_ReturnsProduct()
    {
        var result = _calculator.Multiply(0, 0);

        Assert.Equal(0, result);
    }
}
