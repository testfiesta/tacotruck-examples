import { describe, test, expect } from "bun:test";
import { add, subtract, multiply, divide } from "../src/calculator";

describe("Calculator", () => {
  describe("add", () => {
    test("should add positive numbers", () => {
      expect(add(5, 3)).toBe(8);
    });

    test("should add negative numbers", () => {
      expect(add(-2, -3)).toBe(-5);
    });

    test("should add mixed numbers", () => {
      expect(add(-5, 10)).toBe(5);
    });

    test("should add zeros", () => {
      expect(add(0, 0)).toBe(0);
    });
  });

  describe("subtract", () => {
    test("should subtract positive numbers", () => {
      expect(subtract(10, 5)).toBe(5);
    });

    test("should subtract negative numbers", () => {
      expect(subtract(-5, -3)).toBe(-2);
    });

    test("should subtract mixed numbers", () => {
      expect(subtract(5, 10)).toBe(-5);
    });

    test("should subtract zeros", () => {
      expect(subtract(0, 0)).toBe(0);
    });
  });

  describe("multiply", () => {
    test("should multiply positive numbers", () => {
      expect(multiply(5, 3)).toBe(15);
    });

    test("should multiply negative numbers", () => {
      expect(multiply(-2, -3)).toBe(6);
    });

    test("should multiply mixed numbers", () => {
      expect(multiply(-5, 10)).toBe(-50);
    });

    test("should multiply by zero", () => {
      expect(multiply(5, 0)).toBe(0);
    });
  });

  describe("divide", () => {
    test("should divide positive numbers", () => {
      expect(divide(10, 2)).toBe(5);
    });

    test("should divide negative numbers", () => {
      expect(divide(-6, -3)).toBe(2);
    });

    test("should divide mixed numbers", () => {
      expect(divide(-10, 5)).toBe(-2);
    });

    test("should throw when dividing by zero", () => {
      expect(() => divide(5, 0)).toThrow("Division by zero");
    });
  });
});
