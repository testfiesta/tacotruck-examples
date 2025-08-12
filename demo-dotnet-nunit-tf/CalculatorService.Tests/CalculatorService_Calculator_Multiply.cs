using System;
using CalculatorService;

namespace CalculatorService.Tests;

[Category("Calculator Multiply")]
public class CalculatorService_Calculator_Multiply
{
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    [Test]
    [TestCase(2, 1, 2)]
    [TestCase(5, 3, 15)]
    public void Calculator_Multiplies_TwoPositiveNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(-2, -3, 6)]
    [TestCase(-10, -6, 60.0d)]
    public void Calculator_Multiplies_TwoNegativeNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(-5, 10, -50.0d)]
    [TestCase(-10.4, 6.3, -65.0d)]
    public void Calculator_Multiplies_MixedNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = Math.Ceiling(_calculator.Multiply(a, b));

        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Calculator_Multiplies_Two_Zeroes_And_ReturnsProduct()
    {
        var result = _calculator.Multiply(0, 0);

        Assert.That(result, Is.EqualTo(0.0d));
    }
}
