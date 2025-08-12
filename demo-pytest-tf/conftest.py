import pytest
from calculator import Calculator

# Shared fixture available to all tests
@pytest.fixture(scope="session")
def calc_session():
    """Calculator fixture that's created once per test session."""
    print("\nCreating calculator for the entire test session")
    return Calculator()

# Example of a fixture with setup and teardown
@pytest.fixture
def calc_with_history():
    """Calculator with history tracking."""
    print("\nSetting up calculator with history")
    calc = Calculator()
    history = []
    
    # Monkey patch the calculator to track operation history
    original_add = calc.add
    original_subtract = calc.subtract
    original_multiply = calc.multiply
    original_divide = calc.divide
    
    def add_with_history(a, b):
        result = original_add(a, b)
        history.append(f"Added {a} and {b}, got {result}")
        return result
    
    def subtract_with_history(a, b):
        result = original_subtract(a, b)
        history.append(f"Subtracted {b} from {a}, got {result}")
        return result
    
    def multiply_with_history(a, b):
        result = original_multiply(a, b)
        history.append(f"Multiplied {a} and {b}, got {result}")
        return result
    
    def divide_with_history(a, b):
        result = original_divide(a, b)
        history.append(f"Divided {a} by {b}, got {result}")
        return result
    
    calc.add = add_with_history
    calc.subtract = subtract_with_history
    calc.multiply = multiply_with_history
    calc.divide = divide_with_history
    
    # Return both calculator and history
    yield calc, history
    
    # Teardown code
    print("\nTearing down calculator with history")
    calc.add = original_add
    calc.subtract = original_subtract
    calc.multiply = original_multiply
    calc.divide = original_divide 