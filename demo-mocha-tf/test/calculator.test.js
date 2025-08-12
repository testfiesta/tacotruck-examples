const calculator = require("../src/calculator");
const chai = require("chai");
const expect = chai.expect;

describe("Calculator tests", () => {
  it("adding 1 + 2 should return 3", () => {
    expect(calculator.add(1, 2)).to.equal(3);
  });

  it("should add negative numbers", () => {
    expect(calculator.add(-2, -3)).to.equal(-5);
  });

  it("should add mixed numbers", () => {
    expect(calculator.add(-5, 10)).to.equal(5);
  });

  it("subtracting 2 from 10 should return 8", () => {
    var result = calculator.subtract(10, 2);
    expect(result).to.equal(8);
  });

  it("multiplying 2 and 4 should return 8", () => {
    var result = calculator.multiply(2, 4);
    expect(result).to.equal(8);
  });

  it("dividing 10 by 2 should return 5", () => {
    var result = calculator.divide(10, 2);
    expect(result).to.equal(5);
  });

});
