import pytest
from calculator import Calculator

@pytest.fixture
def calc():
    return Calculator()

def test_add(calc):
    assert calc.add(1, 2) == 3
    assert calc.add(-1, 1) == 0
    assert calc.add(-1, -1) == -2

def test_subtract(calc):
    assert calc.subtract(3, 2) == 1
    assert calc.subtract(1, 1) == 0
    assert calc.subtract(-1, -1) == 0

def test_multiply(calc):
    assert calc.multiply(2, 3) == 6
    assert calc.multiply(-2, 3) == -6
    assert calc.multiply(-2, -3) == 6

def test_divide(calc):
    assert calc.divide(6, 3) == 2
    assert calc.divide(5, 2) == 2.5
    assert calc.divide(-6, 3) == -2

def test_divide_by_zero(calc):
    with pytest.raises(ValueError):
        calc.divide(1, 0)

@pytest.mark.parametrize("a, b, expected", [
    (1, 2, 3),
    (0, 0, 0),
    (-1, 1, 0),
    (0.1, 0.2, 0.3),
])
def test_add_params(calc, a, b, expected):
    assert calc.add(a, b) == pytest.approx(expected)
