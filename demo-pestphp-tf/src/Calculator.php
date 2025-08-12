<?php

namespace Testfiesta\DemoPestphpTf;

class Calculator
{
    /**
     * Add two numbers together
     *
     * @param float|int $a First number
     * @param float|int $b Second number
     * @return float|int Result of addition
     */
    public function add($a, $b)
    {
        return $a + $b;
    }

    /**
     * Subtract the second number from the first
     *
     * @param float|int $a First number
     * @param float|int $b Second number to subtract
     * @return float|int Result of subtraction
     */
    public function subtract($a, $b)
    {
        return $a - $b;
    }

    /**
     * Multiply two numbers together
     *
     * @param float|int $a First number
     * @param float|int $b Second number
     * @return float|int Result of multiplication
     */
    public function multiply($a, $b)
    {
        return $a * $b;
    }

    /**
     * Divide the first number by the second
     *
     * @param float|int $a First number (dividend)
     * @param float|int $b Second number (divisor)
     * @return float Result of division
     * @throws \InvalidArgumentException If divisor is zero
     */
    public function divide($a, $b): float
    {
        if ($b == 0) {
            throw new \InvalidArgumentException('Division by zero is not allowed');
        }

        return $a / $b;
    }
}
