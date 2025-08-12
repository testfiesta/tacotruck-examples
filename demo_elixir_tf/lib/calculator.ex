defmodule Calculator do
  @moduledoc """
  A simple calculator module that provides basic arithmetic operations.
  """

  @doc """
  Adds two numbers together.

  ## Examples

      iex> Calculator.add(2, 3)
      5
      iex> Calculator.add(2.5, 3.5)
      6.0

  """
  def add(a, b) do
    a + b
  end

  @doc """
  Subtracts the second number from the first.

  ## Examples

      iex> Calculator.subtract(5, 2)
      3
      iex> Calculator.subtract(2, 5)
      -3

  """
  def subtract(a, b) do
    a - b
  end

  @doc """
  Multiplies two numbers together.

  ## Examples

      iex> Calculator.multiply(2, 3)
      6
      iex> Calculator.multiply(2.5, 2)
      5.0

  """
  def multiply(a, b) do
    a * b
  end

  @doc """
  Divides the first number by the second.
  Raises an ArithmeticError when attempting to divide by zero.

  ## Examples

      iex> Calculator.divide(6, 2)
      3.0
      iex> Calculator.divide(5, 2)
      2.5

  ## Error cases

      iex> Calculator.divide(1, 0)
      ** (ArithmeticError) division by zero

  """
  def divide(_a, 0) do
    raise ArithmeticError, "division by zero"
  end

  def divide(a, b) do
    a / b
  end
end
