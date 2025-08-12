package calculator_test

import (
	"testing"

	"github.com/demo-tf/calculator/calculator"
)

func TestAdd(t *testing.T) {
	// Test cases
	tests := []struct {
		name     string
		a        int
		b        int
		expected int
	}{
		{"Positive numbers", 5, 3, 8},
		{"Negative numbers", -2, -3, -5},
		{"Mixed numbers", -5, 10, 5},
		{"Zeros", 0, 0, 0},
	}

	// Run test cases
	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			result := calculator.Add(tt.a, tt.b)
			if result != tt.expected {
				t.Errorf("Addition result should match expected value: expected %d, got %d", tt.expected, result)
			}
		})
	}
}

func TestSubtract(t *testing.T) {
	tests := []struct {
		name     string
		a        int
		b        int
		expected int
	}{
		{"Positive numbers", 10, 5, 5},
		{"Negative numbers", -5, -3, -2},
		{"Mixed numbers", 5, 10, -5},
		{"Zeros", 0, 0, 0},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			result := calculator.Subtract(tt.a, tt.b)
			if result != tt.expected {
				t.Errorf("Subtraction result should match expected value: expected %d, got %d", tt.expected, result)
			}
		})
	}
}

func TestMultiply(t *testing.T) {
	tests := []struct {
		name     string
		a        int
		b        int
		expected int
	}{
		{"Positive numbers", 5, 3, 15},
		{"Negative numbers", -2, -3, 6},
		{"Mixed numbers", -5, 10, -50},
		{"Zero multiplication", 5, 0, 0},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			result := calculator.Multiply(tt.a, tt.b)
			if result != tt.expected {
				t.Errorf("Multiplication result should match expected value: expected %d, got %d", tt.expected, result)
			}
		})
	}
}

func TestDivide(t *testing.T) {
	// Test cases for successful division
	tests := []struct {
		name     string
		a        int
		b        int
		expected int
		hasError bool
	}{
		{"Positive numbers", 10, 2, 5, false},
		{"Negative numbers", -6, -3, 2, false},
		{"Mixed numbers", -10, 5, -2, false},
		{"Division by zero", 5, 0, 0, true},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			result, err := calculator.Divide(tt.a, tt.b)
			
			if tt.hasError {
				if err == nil {
					t.Error("Expected an error for division by zero")
				}
			} else {
				if err != nil {
					t.Errorf("Did not expect an error for valid division: %v", err)
				}
				if result != tt.expected {
					t.Errorf("Division result should match expected value: expected %d, got %d", tt.expected, result)
				}
			}
		})
	}
} 