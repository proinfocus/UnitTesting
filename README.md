# Unit Testing
This repo demostrate the simple use of xUnit framework for Unit Testing along with FluentAssertions.

It has a simple Maths class with 4 operations and 1 operation fails as the expected result in
milliseconds surpasses due to a for loop which shouldn't have been in the method.

## Passing Test
- Divide_ByNonZero_ReturnsResult_Within_100ms
- Divide_ByZero_Throws_DivideByZeroException
- Multiply_ReturnsResult_Within_100ms
- Subtract_ReturnsResult_Within_100ms

## Failing Test
- Add_ReturnsResult_Within_100ms
  - a loop is added in the method to simulate taking long time to complete.
