let display = document.getElementById('display');
let result = document.getElementById('result');
let currentInput = '';
let operator = '';
let previousInput = '';

function appendToDisplay(value) {
    if (['+', '-', '*', '/'].includes(value)) {
        if (currentInput !== '') {
            if (previousInput !== '' && operator !== '') {
                calculate();
            }
            previousInput = currentInput;
            operator = value;
            currentInput = '';
            display.value = previousInput + ' ' + operator + ' ';
        }
    } else {
        currentInput += value;
        if (operator !== '') {
            display.value = previousInput + ' ' + operator + ' ' + currentInput;
        } else {
            display.value = currentInput;
        }
    }
}

function clearDisplay() {
    display.value = '';
    result.textContent = '';
    currentInput = '';
    operator = '';
    previousInput = '';
}

function calculate() {
    if (previousInput !== '' && currentInput !== '' && operator !== '') {
        let num1 = parseFloat(previousInput);
        let num2 = parseFloat(currentInput);
        let calculationResult;

        switch (operator) {
            case '+':
                calculationResult = num1 + num2;
                break;
            case '-':
                calculationResult = num1 - num2;
                break;
            case '*':
                calculationResult = num1 * num2;
                break;
            case '/':
                if (num2 === 0) {
                    result.textContent = 'Error: Division by zero';
                    display.value = previousInput;
                    currentInput = previousInput;
                    operator = '';
                    previousInput = '';
                    return;
                }
                calculationResult = num1 / num2;
                break;
            default:
                return;
        }

        calculationResult = Math.round(calculationResult * 100000000) / 100000000;
        
        display.value = calculationResult;
        result.textContent = `${previousInput} ${operator} ${currentInput} = ${calculationResult}`;
        
        currentInput = calculationResult.toString();
        operator = '';
        previousInput = '';
    }
}

document.addEventListener('keydown', function(event) {
    const key = event.key;
    
    if (key >= '0' && key <= '9') {
        appendToDisplay(key);
    } else if (key === '.') {
        appendToDisplay('.');
    } else if (['+', '-', '*', '/'].includes(key)) {
        appendToDisplay(key);
    } else if (key === 'Enter' || key === '=') {
        calculate();
    } else if (key === 'Escape' || key === 'c' || key === 'C') {
        clearDisplay();
    }
});
