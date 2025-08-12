import pytest

def test_session_calculator(calc_session):
    assert calc_session.add(1, 1) == 2
    assert calc_session.multiply(2, 3) == 6

def test_calculator_history(calc_with_history):
    calc, history = calc_with_history

    calc.add(2, 3)
    calc.subtract(10, 4)
    calc.multiply(3, 3)

    assert len(history) == 3
    assert "Added 2 and 3, got 5" in history
    assert "Subtracted 4 from 10, got 6" in history
    assert "Multiplied 3 and 3, got 9" in history

@pytest.mark.skip(reason="This test is not implemented yet")
def test_future_feature():
    assert False

@pytest.mark.skipif(1 + 1 == 2, reason="Skipping because math works")
def test_conditional_skip():
    assert False

@pytest.mark.xfail(reason="Division by zero should raise an error")
def test_expected_failure(calc_session):
    calc_session.divide(1, 0)

@pytest.mark.slow
def test_slow_operation(calc_session):
    result = 0
    for i in range(1000):
        result = calc_session.add(result, i)
    assert result == 499500
