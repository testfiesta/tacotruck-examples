using System;
using CalculatorService;

namespace CalculatorService.Tests;

[Category("Calculator Divide")]
public class CalculatorService_Calculator_Divide
{
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    [Test]
    [TestCase(2, 1, 2)]
    [TestCase(5, 3, 1.6666666666666667)]
    public void Calculator_Divides_TwoPositiveNumbers_And_ReturnsQuotient(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(-2, -3, 0.6666666666666666)]
    [TestCase(-10, -6, 1.6666666666666667)]
    public void Calculator_Divides_TwoNegativeNumbers_And_ReturnsQuotient(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Calculator_Divides_Zero_By_NonZero_And_ReturnsQuotient()
    {
        var result = _calculator.Divide(0, 1);

        Assert.That(result, Is.EqualTo(0.0d));
    }

    [Test]
    public void Calculator_Divides_NonZero_By_Zero_And_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Divide(1, 0));
    }
}
