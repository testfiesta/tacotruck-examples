const calculator = require("../src/calculator");

describe("Calculator tests", () => {
  test("adding 1 + 2 should return 3", () => {
    expect(calculator.add(1, 2)).toBe(3);
  });

  test("should add negative numbers", () => {
    expect(calculator.add(-2, -3)).toBe(-5);
  });

  test("should add mixed numbers", () => {
    expect(calculator.add(-5, 10)).toBe(5);
  });

  test("subtracting 2 from 10 should return 8", () => {
    var result = calculator.subtract(10, 2);
    expect(result).toBe(8);
  });

  test("multiplying 2 and 4 should return 8", () => {
    var result = calculator.multiply(2, 4);
    expect(result).toBe(8);
  });

  test("dividing 10 by 2 should return 5", () => {
    var result = calculator.divide(10, 2);
    expect(result).toBe(5);
  });

});
