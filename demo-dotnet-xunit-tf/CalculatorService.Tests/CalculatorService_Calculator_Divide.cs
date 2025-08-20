using System;
using CalculatorService;

namespace CalculatorService.Tests;

public class CalculatorService_Calculator_Divide
{
    readonly Calculator _calculator = new();

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(5, 3, 1.6666666666666667)]
    public void Calculator_Divides_TwoPositiveNumbers_And_ReturnsQuotient(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-2, -3, 0.6666666666666666)]
    [InlineData(-10, -6, 1.6666666666666667)]
    public void Calculator_Divides_TwoNegativeNumbers_And_ReturnsQuotient(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Calculator_Divides_Zero_By_NonZero_And_ReturnsQuotient()
    {
        var result = _calculator.Divide(0, 1);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Calculator_Divides_NonZero_By_Zero_And_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Divide(1, 0));
    }
}
