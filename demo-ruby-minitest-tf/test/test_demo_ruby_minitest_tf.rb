# frozen_string_literal: true

require "test_helper"

class TestDemoRubyMinitestTf < Minitest::Test
  def test_that_it_has_a_version_number
    refute_nil ::DemoRubyMinitestTf::VERSION
  end
end

class TestCalculator < Minitest::Test
  def setup
    @calculator = DemoRubyMinitestTf::Calculator.new
  end

  # Test add method
  def test_add_two_positive_numbers
    assert_equal 5, @calculator.add(2, 3)
  end

  def test_add_positive_and_negative_number
    assert_equal(-1, @calculator.add(2, -3))
  end

  def test_add_two_negative_numbers
    assert_equal(-5, @calculator.add(-2, -3))
  end

  def test_add_zero
    assert_equal 2, @calculator.add(2, 0)
  end

  def test_add_decimal_numbers
    assert_equal 6.0, @calculator.add(2.5, 3.5)
  end

  # Test subtract method
  def test_subtract_two_positive_numbers
    assert_equal 2, @calculator.subtract(5, 3)
  end

  def test_subtract_negative_from_positive_number
    assert_equal 8, @calculator.subtract(5, -3)
  end

  def test_subtract_positive_from_negative_number
    assert_equal(-8, @calculator.subtract(-5, 3))
  end

  def test_subtract_zero
    assert_equal 5, @calculator.subtract(5, 0)
  end

  # Test multiply method
  def test_multiply_two_positive_numbers
    assert_equal 6, @calculator.multiply(2, 3)
  end

  def test_multiply_positive_and_negative_number
    assert_equal(-6, @calculator.multiply(2, -3))
  end

  def test_multiply_two_negative_numbers
    assert_equal 6, @calculator.multiply(-2, -3)
  end

  def test_multiply_by_zero
    assert_equal 0, @calculator.multiply(2, 0)
  end

  # Test divide method
  def test_divide_two_positive_numbers
    assert_equal 2.0, @calculator.divide(6, 3)
  end

  def test_divide_returns_float_for_division_results
    assert_equal 2.5, @calculator.divide(5, 2)
  end

  def test_divide_positive_by_negative_number
    assert_equal(-2.0, @calculator.divide(6, -3))
  end

  def test_divide_negative_by_positive_number
    assert_equal(-2.0, @calculator.divide(-6, 3))
  end

  def test_divide_raises_error_when_dividing_by_zero
    assert_raises(ZeroDivisionError) { @calculator.divide(6, 0) }
  end

  # Test power method
  def test_power_raises_number_to_positive_power
    assert_equal 8, @calculator.power(2, 3)
  end

  def test_power_raises_number_to_zero
    assert_equal 1, @calculator.power(2, 0)
  end

  def test_power_raises_number_to_negative_power
    assert_equal 0.5, @calculator.power(2, -1)
  end

  def test_power_raises_negative_number_to_even_power
    assert_equal 4, @calculator.power(-2, 2)
  end

  def test_power_raises_negative_number_to_odd_power
    assert_equal(-8, @calculator.power(-2, 3))
  end

  # Test sqrt method
  def test_sqrt_calculates_square_root_of_positive_number
    assert_equal 2.0, @calculator.sqrt(4)
  end

  def test_sqrt_calculates_square_root_of_zero
    assert_equal 0.0, @calculator.sqrt(0)
  end

  def test_sqrt_raises_error_for_negative_numbers
    assert_raises(ArgumentError) { @calculator.sqrt(-4) }
  end
end
