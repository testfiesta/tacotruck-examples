using System;
using CalculatorService;

namespace CalculatorService.Tests;

[TestClass]
public class CalculatorService_Calculator_Add
{
    private Calculator _calculator = null!;

    [TestInitialize]
    public void TestInitialize()
    {
        _calculator = new Calculator();
    }

    [TestMethod]
    [DataRow(2, 1, 3)]
    [DataRow(5, 3, 8)]
    public void Calculator_Adds_TwoPositiveNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = _calculator.Add(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -3, -5)]
    [DataRow(-10, -6, -16)]
    public void Calculator_Adds_TwoNegativeNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = _calculator.Add(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-5, 10, 5.0d)]
    [DataRow(-10.4, 6.3, -4.0d)]
    public void Calculator_Adds_MixedNumbers_And_ReturnsSum(double a, double b, double expected)
    {
        var result = Math.Ceiling(_calculator.Add(a, b));

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Calculator_Adds_Two_Zeroes_And_ReturnsSum()
    {
        var result = _calculator.Add(0, 0);

        Assert.AreEqual(0.0d, result);
    }
}
