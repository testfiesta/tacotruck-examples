pub fn add(a: i32, b: i32) -> i32 {
    a + b
}

pub fn subtract(a: i32, b: i32) -> i32 {
    a - b
}

pub fn multiply(a: i32, b: i32) -> i32 {
    a * b
}

pub fn divide(a: i32, b: i32) -> i32 {
    if b == 0 {
        panic!("Division by zero is not allowed");
    }
    a / b
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn it_adds_two_positive_numbers_and_returns_the_correct_result() {
        let result = add(2, 2);
        assert_eq!(result, 4);
    }

    #[test]
    fn it_adds_two_negative_numbers_and_returns_the_correct_result() {
        let result = add(-2, -2);
        assert_eq!(result, -4);
    }

    #[test]
    fn it_adds_two_mixed_numbers_and_returns_the_correct_result() {
        let result = add(-5, 10);
        assert_eq!(result, 5);
    }

    #[test]
    fn it_adds_two_zeros_and_returns_the_correct_result() {
        let result = add(0, 0);
        assert_eq!(result, 0);
    }

    #[test]
    fn it_adds_subtracts_two_positive_numbers_and_returns_the_correct_result() {
        let result = subtract(5, 3);
        assert_eq!(result, 2);
    }

    #[test]
    fn it_adds_subtracts_two_negative_numbers_and_returns_the_correct_result() {
        let result = subtract(-5, -3);
        assert_eq!(result, -2);
    }

    #[test]
    fn it_subtracts_two_mixed_numbers_and_returns_the_correct_result() {
        let result = subtract(-5, 3);
        assert_eq!(result, -8);
    }

    #[test]
    fn it_subtracts_two_zeros_and_returns_the_correct_result() {
        let result = subtract(0, 0);
        assert_eq!(result, 0);
    }

    #[test]
    fn it_multiplies_two_positive_numbers_and_returns_the_correct_result() {
        let result = multiply(2, 3);
        assert_eq!(result, 6);
    }

    #[test]
    fn it_multiplies_two_negative_numbers_and_returns_the_correct_result() {
        let result = multiply(-2, -3);
        assert_eq!(result, 6);
    }

    #[test]
    fn it_multiplies_two_mixed_numbers_and_returns_the_correct_result() {
        let result = multiply(-2, 3);
        assert_eq!(result, -6);
    }

    #[test]
    fn it_multiplies_two_zero_numbers_and_returns_the_correct_result() {
        let result = multiply(0, 0);
        assert_eq!(result, 0);
    }

    #[test]
    fn it_divides_two_positive_numbers_and_returns_the_correct_result() {
        let result = divide(6, 3);
        assert_eq!(result, 2);
    }

    #[test]
    fn it_divides_two_negative_numbers_and_returns_the_correct_result() {
        let result = divide(-6, -3);
        assert_eq!(result, 2);
    }

    #[test]
    fn it_divides_two_mixed_numbers_and_returns_the_correct_result() {
        let result = divide(-6, 3);
        assert_eq!(result, -2);
    }

    #[test]
    #[should_panic(expected = "Division by zero is not allowed")]
    fn it_throws_an_error_when_dividing_by_zero() {
         divide(6, 0);
    }

}
