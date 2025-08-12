<?php

use Testfiesta\DemoPestphpTf\Calculator;

test('add method can add two numbers', function () {
    $calculator = new Calculator();

    expect($calculator->add(2, 3))->toBe(5);

    expect($calculator->add(5, -3))->toBe(2);
    expect($calculator->add(-5, -3))->toBe(-8);

    expect($calculator->add(2.5, 3.5))->toBe(6.0);
});

test('subtract method can subtract second number from first', function () {
    $calculator = new Calculator();

    expect($calculator->subtract(5, 3))->toBe(2);

    expect($calculator->subtract(3, 5))->toBe(-2);

    expect($calculator->subtract(-3, -5))->toBe(2);

    expect($calculator->subtract(5.5, 2))->toBe(3.5);
});

test('multiply method can multiply two numbers', function () {
    $calculator = new Calculator();

    expect($calculator->multiply(2, 3))->toBe(6);

    expect($calculator->multiply(5, 0))->toBe(0);

    expect($calculator->multiply(2, -3))->toBe(-6);
    expect($calculator->multiply(-2, -3))->toBe(6);

    expect($calculator->multiply(2.5, 2))->toBe(5.0);
});

test('divide method can divide first number by second', function () {
    $calculator = new Calculator();

    expect($calculator->divide(6, 3))->toBe(2.0);

    expect($calculator->divide(5, 2))->toBe(2.5);

    expect($calculator->divide(-6, 3))->toBe(-2.0);
    expect($calculator->divide(6, -3))->toBe(-2.0);
    expect($calculator->divide(-6, -3))->toBe(2.0);
});

test('divide method throws exception when dividing by zero', function () {
    $calculator = new Calculator();

    expect(fn() => $calculator->divide(5, 0))
        ->toThrow(InvalidArgumentException::class, 'Division by zero is not allowed');
});

test('calculator performs all operations correctly with same inputs', function () {
    $calculator = new Calculator();
    $a = 10;
    $b = 2;

    expect($calculator->add($a, $b))->toBe(12);
    expect($calculator->subtract($a, $b))->toBe(8);
    expect($calculator->multiply($a, $b))->toBe(20);
    expect($calculator->divide($a, $b))->toBe(5.0);
});
