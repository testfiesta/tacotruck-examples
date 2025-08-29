# frozen_string_literal: true

require_relative "demo_ruby_minitest_tf/version"

module DemoRubyMinitestTf
  class Error < StandardError; end

  # Calculator class provides basic arithmetic operations
  class Calculator
    # Adds two numbers
    # @param a [Numeric] first number
    # @param b [Numeric] second number
    # @return [Numeric] sum of a and b
    def add(a, b)
      a + b
    end

    # Subtracts second number from first number
    # @param a [Numeric] first number
    # @param b [Numeric] second number
    # @return [Numeric] result of a - b
    def subtract(a, b)
      a - b
    end

    # Multiplies two numbers
    # @param a [Numeric] first number
    # @param b [Numeric] second number
    # @return [Numeric] product of a and b
    def multiply(a, b)
      a * b
    end

    # Divides first number by second number
    # @param a [Numeric] first number
    # @param b [Numeric] second number
    # @return [Numeric] result of a / b
    # @raise [ZeroDivisionError] if b is zero
    def divide(a, b)
      raise ZeroDivisionError, "Cannot divide by zero" if b.zero?
      a / b.to_f
    end

    # Raises first number to the power of second number
    # @param a [Numeric] base
    # @param b [Numeric] exponent
    # @return [Numeric] result of a raised to the power of b
    def power(a, b)
      a ** b
    end

    # Calculates the square root of a number
    # @param a [Numeric] number
    # @return [Numeric] square root of a
    # @raise [ArgumentError] if a is negative
    def sqrt(a)
      raise ArgumentError, "Cannot calculate square root of negative number" if a < 0
      Math.sqrt(a)
    end
  end
end
