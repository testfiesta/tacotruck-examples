using System;
using CalculatorService;

namespace CalculatorService.Tests;

[Category("Calculator Add")]
public class CalculatorService_Calculator_Add
{
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    [Test]
    [TestCase(2, 1, 3)]
    [TestCase(5, 3, 8)]
    public void Calculator_Adds_TwoPositiveNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = _calculator.Add(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(-2, -3, -5)]
    [TestCase(-10, -6, -16)]
    public void Calculator_Adds_TwoNegativeNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = _calculator.Add(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(-5, 10, 5.0d)]
    [TestCase(-10.4, 6.3, -4.0d)]
    public void Calculator_Adds_MixedNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = Math.Ceiling(_calculator.Add(a, b));

        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Calculator_Adds_Two_Zeroes_And_ReturnsSum()
    {
        var result = _calculator.Add(0, 0);

        Assert.That(result, Is.EqualTo(0.0d));
    }
}
