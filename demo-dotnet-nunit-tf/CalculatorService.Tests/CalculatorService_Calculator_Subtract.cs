using System;
using CalculatorService;

namespace CalculatorService.Tests;

[Category("Calculator Subtract")]
public class CalculatorService_Calculator_Subtract
{
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    [Test]
    [TestCase(2, 1, 1)]
    [TestCase(5, 3, 2)]
    public void Calculator_Subtracts_TwoPositiveNumbers_And_ReturnsDifference(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(-2, -3, 1)]
    [TestCase(-10, -6, -4.0d)]
    public void Calculator_Subtracts_TwoNegativeNumbers_And_ReturnsDifference(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(-5, 10, -15.0d)]
    [TestCase(-10.4, 6.3, -16.0d)]
    public void Calculator_Subtracts_MixedNumbers_And_ReturnsDifference(double a, double b, double expected)
    {
        var result = Math.Ceiling(_calculator.Subtract(a, b));

        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Calculator_Subtracts_Two_Zeroes_And_ReturnsZero()
    {
        var result = _calculator.Subtract(0, 0);

        Assert.That(result, Is.EqualTo(0.0d));
    }
}
