package calculator_test

import (
	"testing"

	"github.com/demo-tf/calculator-testify/calculator"
	"github.com/stretchr/testify/assert"
	"github.com/stretchr/testify/require"
	"github.com/stretchr/testify/suite"
)

type CalculatorTestSuite struct {
	suite.Suite
}

func (suite *CalculatorTestSuite) SetupSuite() {
	suite.T().Log("Setting up calculator test suite")
}

func (suite *CalculatorTestSuite) TearDownSuite() {
	suite.T().Log("Tearing down calculator test suite")
}

func (suite *CalculatorTestSuite) SetupTest() {
	suite.T().Log("Setting up individual test")
}

func (suite *CalculatorTestSuite) TearDownTest() {
	suite.T().Log("Tearing down individual test")
}

func (suite *CalculatorTestSuite) TestAdd() {
	result := calculator.Add(5, 3)
	
	assert.Equal(suite.T(), 8, result, "Addition should work correctly")
	assert.NotEqual(suite.T(), 10, result, "Result should not be 10")
	
	assert.IsType(suite.T(), 0, result, "Result should be an integer")
	
	assert.Greater(suite.T(), result, 0, "Result should be positive")
	assert.Less(suite.T(), result, 10, "Result should be less than 10")
}

func (suite *CalculatorTestSuite) TestAddWithTable() {
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
		{"Large numbers", 1000, 2000, 3000},
	}

	for _, tt := range tests {
		suite.Run(tt.name, func() {
			result := calculator.Add(tt.a, tt.b)
			assert.Equal(suite.T(), tt.expected, result, 
				"Addition of %d and %d should equal %d", tt.a, tt.b, tt.expected)
		})
	}
}

func (suite *CalculatorTestSuite) TestSubtract() {
	result := calculator.Subtract(10, 5)
	
	require.Equal(suite.T(), 5, result, "Subtraction should work correctly")
	require.NotNil(suite.T(), result, "Result should not be nil")
	
	assert.IsType(suite.T(), 0, result, "Result should be an integer")
}

func (suite *CalculatorTestSuite) TestSubtractWithTable() {
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
		{"Same numbers", 7, 7, 0},
	}

	for _, tt := range tests {
		suite.Run(tt.name, func() {
			result := calculator.Subtract(tt.a, tt.b)
			require.Equal(suite.T(), tt.expected, result, 
				"Subtraction of %d and %d should equal %d", tt.a, tt.b, tt.expected)
		})
	}
}

func (suite *CalculatorTestSuite) TestMultiply() {
	result := calculator.Multiply(5, 3)
	
	assert.Equal(suite.T(), 15, result, "Multiplication should work correctly")
	
	assert.Greater(suite.T(), result, 10, "Result should be greater than 10")
	assert.LessOrEqual(suite.T(), result, 20, "Result should be less than or equal to 20")
	
	assert.IsType(suite.T(), 0, result, "Result should be an integer")
	assert.NotZero(suite.T(), result, "Result should not be zero")
}

func (suite *CalculatorTestSuite) TestMultiplyWithTable() {
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
		{"Identity", 1, 7, 7},
	}

	for _, tt := range tests {
		suite.Run(tt.name, func() {
			result := calculator.Multiply(tt.a, tt.b)
			
			assert.Equal(suite.T(), tt.expected, result, 
				"Multiplication of %d and %d should equal %d", tt.a, tt.b, tt.expected)
			assert.IsType(suite.T(), 0, result, "Result should be an integer")
			
			if tt.a == 0 || tt.b == 0 {
				assert.Zero(suite.T(), result, "Multiplication by zero should result in zero")
			} else {
				assert.NotZero(suite.T(), result, "Non-zero multiplication should not result in zero")
			}
		})
	}
}

func (suite *CalculatorTestSuite) TestDivide() {
	result, err := calculator.Divide(10, 2)
	
	require.NoError(suite.T(), err, "Should not have error for valid division")
	assert.Equal(suite.T(), 5, result, "Division should work correctly")
	
	result, err = calculator.Divide(5, 0)
	
	require.Error(suite.T(), err, "Should have error for division by zero")
	assert.Equal(suite.T(), 0, result, "Result should be 0 when error occurs")
	assert.Contains(suite.T(), err.Error(), "division by zero", "Error message should contain 'division by zero'")
}

func (suite *CalculatorTestSuite) TestDivideWithTable() {
	tests := []struct {
		name        string
		a           int
		b           int
		expected    int
		expectError bool
		errorMsg    string
	}{
		{"Positive numbers", 10, 2, 5, false, ""},
		{"Negative numbers", -6, -3, 2, false, ""},
		{"Mixed numbers", -10, 5, -2, false, ""},
		{"Division by zero", 5, 0, 0, true, "division by zero"},
		{"Zero dividend", 0, 5, 0, false, ""},
		{"Large numbers", 1000, 10, 100, false, ""},
	}

	for _, tt := range tests {
		suite.Run(tt.name, func() {
			result, err := calculator.Divide(tt.a, tt.b)
			
			if tt.expectError {
				require.Error(suite.T(), err, "Expected an error")
				assert.Contains(suite.T(), err.Error(), tt.errorMsg, "Error message should match")
				assert.Equal(suite.T(), tt.expected, result, "Result should be expected value on error")
			} else {
				require.NoError(suite.T(), err, "Did not expect an error")
				assert.Equal(suite.T(), tt.expected, result, 
					"Division of %d by %d should equal %d", tt.a, tt.b, tt.expected)
			}
			
			assert.IsType(suite.T(), 0, result, "Result should be an integer")
		})
	}
}

func (suite *CalculatorTestSuite) TestCalculatorProperties() {
	a, b := 5, 3
	result1 := calculator.Add(a, b)
	result2 := calculator.Add(b, a)
	assert.Equal(suite.T(), result1, result2, "Addition should be commutative")
	
	identity := calculator.Multiply(7, 1)
	assert.Equal(suite.T(), 7, identity, "Multiplication by 1 should return the original number")
	
	zero := calculator.Multiply(7, 0)
	assert.Equal(suite.T(), 0, zero, "Multiplication by 0 should return 0")
}

func (suite *CalculatorTestSuite) TestCalculatorEdgeCases() {
	largeResult := calculator.Add(1000000, 2000000)
	assert.Equal(suite.T(), 3000000, largeResult, "Should handle large numbers")
	
	smallResult := calculator.Subtract(-1000000, -2000000)
	assert.Equal(suite.T(), 1000000, smallResult, "Should handle small numbers")
	
	multResult := calculator.Multiply(1000, 1000)
	assert.Equal(suite.T(), 1000000, multResult, "Should handle large multiplication")
}

func TestCalculatorTestSuite(t *testing.T) {
	suite.Run(t, new(CalculatorTestSuite))
}

func TestAddStandalone(t *testing.T) {
	result := calculator.Add(2, 3)
	assert.Equal(t, 5, result, "Standalone test should work")
}

func TestSubtractStandalone(t *testing.T) {
	result := calculator.Subtract(5, 2)
	require.Equal(t, 3, result, "Standalone test with require should work")
}

func TestMultiplyStandalone(t *testing.T) {
	result := calculator.Multiply(4, 5)
	assert.Equal(t, 20, result, "Standalone multiplication test should work")
}

func TestDivideStandalone(t *testing.T) {
	result, err := calculator.Divide(8, 2)
	require.NoError(t, err, "Standalone division should not error")
	assert.Equal(t, 4, result, "Standalone division test should work")
}
