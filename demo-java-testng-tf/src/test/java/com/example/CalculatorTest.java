package com.example;

import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;
import org.testng.annotations.DataProvider;
import static org.testng.Assert.*;

public class CalculatorTest {
    
    private Calculator calculator;
    
    @BeforeMethod
    public void setUp() {
        calculator = new Calculator();
    }
    
    @Test(description = "Addition of positive numbers")
    public void testAddPositiveNumbers() {
        assertEquals(calculator.add(5, 3), 8);
        assertEquals(calculator.add(7, 3), 10);
        assertEquals(calculator.add(0, 0), 0);
    }
    
    @Test(description = "Addition of negative numbers")
    public void testAddNegativeNumbers() {
        assertEquals(calculator.add(-2, -3), -5);
        assertEquals(calculator.add(-5, 10), 5);
        assertEquals(calculator.add(-1, 1), 0);
    }
    
    @DataProvider(name = "additionData")
    public Object[][] additionDataProvider() {
        return new Object[][] {
            {1, 2, 3},
            {0, 0, 0},
            {-1, 1, 0},
            {10, -5, 5}
        };
    }
    
    @Test(dataProvider = "additionData", description = "Parameterized addition tests")
    public void testAddParameterized(int a, int b, int expected) {
        assertEquals(calculator.add(a, b), expected);
    }
    
    @Test(description = "Subtraction tests")
    public void testSubtract() {
        assertEquals(calculator.subtract(10, 5), 5);
        assertEquals(calculator.subtract(-5, -3), -2);
        assertEquals(calculator.subtract(5, 10), -5);
        assertEquals(calculator.subtract(0, 0), 0);
    }
    
    @Test(description = "Multiplication tests")
    public void testMultiply() {
        assertEquals(calculator.multiply(5, 3), 15);
        assertEquals(calculator.multiply(-2, -3), 6);
        assertEquals(calculator.multiply(-5, 10), -50);
        assertEquals(calculator.multiply(5, 0), 0);
    }
    
    @Test(description = "Division tests")
    public void testDivide() {
        assertEquals(calculator.divide(10, 5), 2.0, 0.001);
        assertEquals(calculator.divide(5, 2), 2.5, 0.001);
        assertEquals(calculator.divide(-6, 3), -2.0, 0.001);
        assertEquals(calculator.divide(-6, -3), 2.0, 0.001);
    }
    
    @Test(description = "Division by zero throws exception", expectedExceptions = IllegalArgumentException.class, expectedExceptionsMessageRegExp = "Cannot divide by zero")
    public void testDivideByZero() {
        calculator.divide(1, 0);
    }
    
    @DataProvider(name = "divideByZeroData")
    public Object[][] divideByZeroDataProvider() {
        return new Object[][] {
            {1}, {5}, {-3}, {100}
        };
    }
    
    @Test(dataProvider = "divideByZeroData", description = "Division by zero with different dividends", expectedExceptions = IllegalArgumentException.class)
    public void testDivideByZeroParameterized(int dividend) {
        calculator.divide(dividend, 0);
    }
}
