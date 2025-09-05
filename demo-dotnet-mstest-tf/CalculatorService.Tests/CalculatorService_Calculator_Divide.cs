using System;
using CalculatorService;

namespace CalculatorService.Tests;

[TestClass]
public class CalculatorService_Calculator_Divide
{
    private Calculator _calculator = null!;

    [TestInitialize]
    public void TestInitialize()
    {
        _calculator = new Calculator();
    }

    [TestMethod]
    [DataRow(6, 2, 3)]
    [DataRow(20, 4, 5)]
    public void Calculator_Divides_TwoPositiveNumbers_And_ReturnsQuotient(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-6, -2, 3)]
    [DataRow(-20, -4, 5)]
    public void Calculator_Divides_TwoNegativeNumbers_And_ReturnsQuotient(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-6, 2, -3)]
    [DataRow(20, -4, -5)]
    public void Calculator_Divides_MixedNumbers_And_ReturnsQuotient(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Calculator_Divides_Zero_By_Number_And_ReturnsZero()
    {
        var result = _calculator.Divide(0, 5);

        Assert.AreEqual(0.0d, result);
    }

    [TestMethod]
    public void Calculator_Divides_By_Zero_And_ThrowsException()
    {
        Assert.ThrowsException<ArgumentException>(() => _calculator.Divide(5, 0));
    }
}
