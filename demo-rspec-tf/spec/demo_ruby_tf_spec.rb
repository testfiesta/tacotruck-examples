# frozen_string_literal: true

RSpec.describe DemoRubyTf do
  it "has a version number" do
    expect(DemoRubyTf::VERSION).not_to be nil
  end
end

RSpec.describe DemoRubyTf::Calculator do
  let(:calculator) { DemoRubyTf::Calculator.new }

  describe "#add" do
    it "adds two positive numbers" do
      expect(calculator.add(2, 3)).to eq(5)
    end

    it "adds a positive and a negative number" do
      expect(calculator.add(2, -3)).to eq(-1)
    end

    it "adds two negative numbers" do
      expect(calculator.add(-2, -3)).to eq(-5)
    end

    it "adds zero" do
      expect(calculator.add(2, 0)).to eq(2)
    end

    it "adds decimal numbers" do
      expect(calculator.add(2.5, 3.5)).to eq(6.0)
    end
  end

  describe "#subtract" do
    it "subtracts two positive numbers" do
      expect(calculator.subtract(5, 3)).to eq(2)
    end

    it "subtracts a negative from a positive number" do
      expect(calculator.subtract(5, -3)).to eq(8)
    end

    it "subtracts a positive from a negative number" do
      expect(calculator.subtract(-5, 3)).to eq(-8)
    end

    it "subtracts zero" do
      expect(calculator.subtract(5, 0)).to eq(5)
    end
  end

  describe "#multiply" do
    it "multiplies two positive numbers" do
      expect(calculator.multiply(2, 3)).to eq(6)
    end

    it "multiplies a positive and a negative number" do
      expect(calculator.multiply(2, -3)).to eq(-6)
    end

    it "multiplies two negative numbers" do
      expect(calculator.multiply(-2, -3)).to eq(6)
    end

    it "multiplies by zero" do
      expect(calculator.multiply(2, 0)).to eq(0)
    end
  end

  describe "#divide" do
    it "divides two positive numbers" do
      expect(calculator.divide(6, 3)).to eq(2.0)
    end

    it "returns a float for division results" do
      expect(calculator.divide(5, 2)).to eq(2.5)
    end

    it "divides a positive by a negative number" do
      expect(calculator.divide(6, -3)).to eq(-2.0)
    end

    it "divides a negative by a positive number" do
      expect(calculator.divide(-6, 3)).to eq(-2.0)
    end

    it "raises an error when dividing by zero" do
      expect { calculator.divide(6, 0) }.to raise_error(ZeroDivisionError)
    end
  end

  describe "#power" do
    it "raises a number to a positive power" do
      expect(calculator.power(2, 3)).to eq(8)
    end

    it "raises a number to zero" do
      expect(calculator.power(2, 0)).to eq(1)
    end

    it "raises a number to a negative power" do
      expect(calculator.power(2, -1)).to eq(0.5)
    end

    it "raises a negative number to an even power" do
      expect(calculator.power(-2, 2)).to eq(4)
    end

    it "raises a negative number to an odd power" do
      expect(calculator.power(-2, 3)).to eq(-8)
    end
  end

  describe "#sqrt" do
    it "calculates the square root of a positive number" do
      expect(calculator.sqrt(4)).to eq(2.0)
    end

    it "calculates the square root of zero" do
      expect(calculator.sqrt(0)).to eq(0.0)
    end

    it "raises an error for negative numbers" do
      expect { calculator.sqrt(-4) }.to raise_error(ArgumentError)
    end
  end
end