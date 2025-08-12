package main

import (
	"fmt"
	"log"

	"github.com/demo-tf/calculator/calculator"
)

func main() {
	a, b := 10, 5
	
	fmt.Printf("Addition: %d + %d = %d\n", a, b, calculator.Add(a, b))
	fmt.Printf("Subtraction: %d - %d = %d\n", a, b, calculator.Subtract(a, b))
	fmt.Printf("Multiplication: %d * %d = %d\n", a, b, calculator.Multiply(a, b))
	
	result, err := calculator.Divide(a, b)
	if err != nil {
		log.Fatalf("Error in division: %v", err)
	}
	fmt.Printf("Division: %d / %d = %d\n", a, b, result)
	
	_, err = calculator.Divide(a, 0)
	if err != nil {
		fmt.Printf("Division by zero error: %v\n", err)
	}
} 