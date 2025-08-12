defmodule CalculatorTest do
  use ExUnit.Case
  doctest Calculator

  describe "add/2" do
    test "adds two positive integers" do
      assert Calculator.add(2, 3) == 5
    end

    test "adds positive and negative integers" do
      assert Calculator.add(5, -3) == 2
    end

    test "adds two negative integers" do
      assert Calculator.add(-2, -3) == -5
    end

    test "adds integers and floats" do
      assert Calculator.add(2, 3.5) == 5.5
    end
  end

  describe "subtract/2" do
    test "subtracts two positive integers" do
      assert Calculator.subtract(5, 3) == 2
    end

    test "subtracts resulting in negative number" do
      assert Calculator.subtract(3, 5) == -2
    end

    test "subtracts with negative numbers" do
      assert Calculator.subtract(-3, -5) == 2
    end

    test "subtracts integers and floats" do
      assert Calculator.subtract(5, 2.5) == 2.5
    end
  end

  describe "multiply/2" do
    test "multiplies two positive integers" do
      assert Calculator.multiply(2, 3) == 6
    end

    test "multiplies positive and negative integers" do
      assert Calculator.multiply(2, -3) == -6
    end

    test "multiplies two negative integers" do
      assert Calculator.multiply(-2, -3) == 6
    end

    test "multiplies integers and floats" do
      assert Calculator.multiply(2, 3.5) == 7.0
    end
  end

  describe "divide/2" do
    test "divides two positive integers" do
      assert Calculator.divide(6, 3) == 2.0
    end

    test "divides resulting in float" do
      assert Calculator.divide(5, 2) == 2.5
    end

    test "divides with negative numbers" do
      assert Calculator.divide(-6, 3) == -2.0
      assert Calculator.divide(6, -3) == -2.0
      assert Calculator.divide(-6, -3) == 2.0
    end

    test "raises error when dividing by zero" do
      assert_raise ArithmeticError, "division by zero", fn ->
        Calculator.divide(5, 0)
      end
    end
  end
end