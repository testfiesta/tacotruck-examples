<?php

namespace Testfiesta\DemoPhpunitTf\Tests;

use PHPUnit\Framework\TestCase;
use Testfiesta\DemoPhpunitTf\Calculator;

class CalculatorTest extends TestCase
{
    public function testAddMethodCanAddTwoNumbers(): void
    {
        $calculator = new Calculator();

        $this->assertEquals(5, $calculator->add(2, 3));

        $this->assertEquals(2, $calculator->add(5, -3));
        $this->assertEquals(-8, $calculator->add(-5, -3));

        $this->assertEquals(6.0, $calculator->add(2.5, 3.5));
    }

    public function testSubtractMethodCanSubtractSecondNumberFromFirst(): void
    {
        $calculator = new Calculator();

        $this->assertEquals(2, $calculator->subtract(5, 3));
        $this->assertEquals(-2, $calculator->subtract(3, 5));
        $this->assertEquals(2, $calculator->subtract(-3, -5));
        $this->assertEquals(3.5, $calculator->subtract(5.5, 2));
    }

    public function testMultiplyMethodCanMultiplyTwoNumbers(): void
    {
        $calculator = new Calculator();

        $this->assertEquals(6, $calculator->multiply(2, 3));

        $this->assertEquals(0, $calculator->multiply(5, 0));

        $this->assertEquals(-6, $calculator->multiply(2, -3));
        $this->assertEquals(6, $calculator->multiply(-2, -3));

        $this->assertEquals(5.0, $calculator->multiply(2.5, 2));
    }

    public function testDivideMethodCanDivideFirstNumberBySecond(): void
    {
        $calculator = new Calculator();

        $this->assertEquals(2.0, $calculator->divide(6, 3));

        $this->assertEquals(2.5, $calculator->divide(5, 2));

        $this->assertEquals(-2.0, $calculator->divide(-6, 3));
        $this->assertEquals(-2.0, $calculator->divide(6, -3));
        $this->assertEquals(2.0, $calculator->divide(-6, -3));
    }

    public function testDivideMethodThrowsExceptionWhenDividingByZero(): void
    {
        $calculator = new Calculator();

        $this->expectException(\InvalidArgumentException::class);
        $this->expectExceptionMessage('Division by zero is not allowed');

        $calculator->divide(5, 0);
    }

    public function testCalculatorPerformsAllOperationsCorrectlyWithSameInputs(): void
    {
        $calculator = new Calculator();
        $a = 10;
        $b = 2;

        $this->assertEquals(12, $calculator->add($a, $b));
        $this->assertEquals(8, $calculator->subtract($a, $b));
        $this->assertEquals(20, $calculator->multiply($a, $b));
        $this->assertEquals(5.0, $calculator->divide($a, $b));
    }
}
