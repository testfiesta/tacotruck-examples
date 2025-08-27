package com.example;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import org.junit.jupiter.params.provider.ValueSource;

import static org.junit.jupiter.api.Assertions.*;

@DisplayName("Calculator Tests")
public class CalculatorTest {
    
    private Calculator calculator;
    
    @BeforeEach
    void setUp() {
        calculator = new Calculator();
    }
    
    @Test
    @DisplayName("Addition of positive numbers")
    void testAddPositiveNumbers() {
        assertEquals(8, calculator.add(5, 3));
        assertEquals(10, calculator.add(7, 3));
        assertEquals(0, calculator.add(0, 0));
    }
    
    @Test
    @DisplayName("Addition of negative numbers")
    void testAddNegativeNumbers() {
        assertEquals(-5, calculator.add(-2, -3));
        assertEquals(5, calculator.add(-5, 10));
        assertEquals(0, calculator.add(-1, 1));
    }
    
    @ParameterizedTest
    @DisplayName("Parameterized addition tests")
    @CsvSource({
        "1, 2, 3",
        "0, 0, 0", 
        "-1, 1, 0",
        "10, -5, 5"
    })
    void testAddParameterized(int a, int b, int expected) {
        assertEquals(expected, calculator.add(a, b));
    }
    
    @Test
    @DisplayName("Subtraction tests")
    void testSubtract() {
        assertEquals(5, calculator.subtract(10, 5));
        assertEquals(-2, calculator.subtract(-5, -3));
        assertEquals(-5, calculator.subtract(5, 10));
        assertEquals(0, calculator.subtract(0, 0));
    }
    
    @Test
    @DisplayName("Multiplication tests")
    void testMultiply() {
        assertEquals(15, calculator.multiply(5, 3));
        assertEquals(6, calculator.multiply(-2, -3));
        assertEquals(-50, calculator.multiply(-5, 10));
        assertEquals(0, calculator.multiply(5, 0));
    }
    
    @Test
    @DisplayName("Division tests")
    void testDivide() {
        assertEquals(2.0, calculator.divide(10, 5), 0.001);
        assertEquals(2.5, calculator.divide(5, 2), 0.001);
        assertEquals(-2.0, calculator.divide(-6, 3), 0.001);
        assertEquals(2.0, calculator.divide(-6, -3), 0.001);
    }
    
    @Test
    @DisplayName("Division by zero throws exception")
    void testDivideByZero() {
        IllegalArgumentException exception = assertThrows(
            IllegalArgumentException.class, 
            () -> calculator.divide(1, 0)
        );
        assertEquals("Cannot divide by zero", exception.getMessage());
    }
    
    @ParameterizedTest
    @DisplayName("Division by zero with different dividends")
    @ValueSource(ints = {1, 5, -3, 100})
    void testDivideByZeroParameterized(int dividend) {
        assertThrows(IllegalArgumentException.class, () -> calculator.divide(dividend, 0));
    }
}
