using System;
using CalculatorService;

namespace CalculatorService.Tests;

[TestClass]
public class CalculatorService_Calculator_Subtract
{
    private Calculator _calculator = null!;

    [TestInitialize]
    public void TestInitialize()
    {
        _calculator = new Calculator();
    }

    [TestMethod]
    [DataRow(5, 3, 2)]
    [DataRow(10, 4, 6)]
    public void Calculator_Subtracts_TwoPositiveNumbers_And_ReturnsResult(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -3, 1)]
    [DataRow(-10, -6, -4)]
    public void Calculator_Subtracts_TwoNegativeNumbers_And_ReturnsResult(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-5, 10, -15)]
    [DataRow(10, -5, 15)]
    public void Calculator_Subtracts_MixedNumbers_And_ReturnsResult(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Calculator_Subtracts_Zero_From_Number_And_ReturnsNumber()
    {
        var result = _calculator.Subtract(5, 0);

        Assert.AreEqual(5.0d, result);
    }

    [TestMethod]
    public void Calculator_Subtracts_Number_From_Zero_And_ReturnsNegativeNumber()
    {
        var result = _calculator.Subtract(0, 5);

        Assert.AreEqual(-5.0d, result);
    }
}
