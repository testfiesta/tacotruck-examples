import { expect } from "jsr:@std/expect";
import { assertThrows } from "jsr:@std/assert";
import { add, divide, multiply, subtract } from "../src/calculator.ts";

Deno.test("add: should add positive numbers", () => {
  expect(add(5, 3)).toBe(8);
});

Deno.test("add: should add negative numbers", () => {
  expect(add(-2, -3)).toBe(-5);
});

Deno.test("add: should add mixed numbers", () => {
  expect(add(-5, 10)).toBe(5);
});

Deno.test("add: should add zeros", () => {
  expect(add(0, 0)).toBe(0);
});

Deno.test("subtract: should subtract positive numbers", () => {
  expect(subtract(10, 5)).toBe(5);
});

Deno.test("subtract: should subtract negative numbers", () => {
  expect(subtract(-5, -3)).toBe(-2);
});

Deno.test("subtract: should subtract mixed numbers", () => {
  expect(subtract(5, 10)).toBe(-5);
});

Deno.test("subtract: should subtract zeros", () => {
  expect(subtract(0, 0)).toBe(0);
});

Deno.test("multiply: should multiply positive numbers", () => {
  expect(multiply(5, 3)).toBe(15);
});

Deno.test("multiply: should multiply negative numbers", () => {
  expect(multiply(-2, -3)).toBe(6);
});

Deno.test("multiply: should multiply mixed numbers", () => {
  expect(multiply(-5, 10)).toBe(-50);
});

Deno.test("multiply: should multiply by zero", () => {
  expect(multiply(5, 0)).toBe(0);
});

Deno.test("divide: should divide positive numbers", () => {
  expect(divide(10, 2)).toBe(5);
});

Deno.test("divide: should divide negative numbers", () => {
  expect(divide(-6, -3)).toBe(2);
});

Deno.test("divide: should divide mixed numbers", () => {
  expect(divide(-10, 5)).toBe(-2);
});

Deno.test("divide: should throw when dividing by zero", () => {
  assertThrows(() => divide(5, 0), Error, "Division by zero");
});
