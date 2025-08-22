package main

import (
	"fmt"
	"log"

	"github.com/demo-tf/calculator-testify/calculator"
)

func main() {
	fmt.Println("=== Golang Calculator with Testify Demo ===")
	fmt.Println()

	a, b := 10, 5
	
	fmt.Printf("Addition: %d + %d = %d\n", a, b, calculator.Add(a, b))
	fmt.Printf("Subtraction: %d - %d = %d\n", a, b, calculator.Subtract(a, b))
	fmt.Printf("Multiplication: %d * %d = %d\n", a, b, calculator.Multiply(a, b))
	
	result, err := calculator.Divide(a, b)
	if err != nil {
		log.Fatalf("Error in division: %v", err)
	}
	fmt.Printf("Division: %d / %d = %d\n", a, b, result)
	
	fmt.Println()
	fmt.Println("=== Error Handling Demo ===")
	_, err = calculator.Divide(a, 0)
	if err != nil {
		fmt.Printf("Division by zero error: %v\n", err)
	}
	
	fmt.Println()
	fmt.Println("=== Negative Numbers Demo ===")
	negA, negB := -10, -3
	fmt.Printf("Addition: %d + %d = %d\n", negA, negB, calculator.Add(negA, negB))
	fmt.Printf("Subtraction: %d - %d = %d\n", negA, negB, calculator.Subtract(negA, negB))
	fmt.Printf("Multiplication: %d * %d = %d\n", negA, negB, calculator.Multiply(negA, negB))
	
	result, err = calculator.Divide(negA, negB)
	if err != nil {
		log.Fatalf("Error in division: %v", err)
	}
	fmt.Printf("Division: %d / %d = %d\n", negA, negB, result)
	
	fmt.Println()
	fmt.Println("=== Mathematical Properties Demo ===")
	
	fmt.Printf("Commutative property: %d + %d = %d + %d = %d\n", 
		a, b, b, a, calculator.Add(a, b))
	
	fmt.Printf("Identity property: %d * 1 = %d\n", 
		a, calculator.Multiply(a, 1))
	
	fmt.Printf("Zero property: %d * 0 = %d\n", 
		a, calculator.Multiply(a, 0))
	
	fmt.Println()
	fmt.Println("=== Demo Complete ===")
	fmt.Println("Run 'go test -v ./test/...' to see the Testify tests in action!")
}
