using System;
using CalculatorService;

namespace CalculatorService.Tests;

[TestClass]
public class CalculatorService_Calculator_Multiply
{
    private Calculator _calculator = null!;

    [TestInitialize]
    public void TestInitialize()
    {
        _calculator = new Calculator();
    }

    [TestMethod]
    [DataRow(2, 3, 6)]
    [DataRow(5, 4, 20)]
    public void Calculator_Multiplies_TwoPositiveNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -3, 6)]
    [DataRow(-5, -4, 20)]
    public void Calculator_Multiplies_TwoNegativeNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, 3, -6)]
    [DataRow(5, -4, -20)]
    public void Calculator_Multiplies_MixedNumbers_And_ReturnsProduct(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Calculator_Multiplies_By_Zero_And_ReturnsZero()
    {
        var result = _calculator.Multiply(5, 0);

        Assert.AreEqual(0.0d, result);
    }

    [TestMethod]
    public void Calculator_Multiplies_Zero_By_Number_And_ReturnsZero()
    {
        var result = _calculator.Multiply(0, 5);

        Assert.AreEqual(0.0d, result);
    }
}
