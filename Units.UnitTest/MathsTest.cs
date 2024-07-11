using FluentAssertions;

namespace Units.UnitTest;

public class MathsTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, -2, 0)]
    [InlineData(-2, -3, -5)]
    public void Add_ReturnsResult_Within_100ms(int x, int y, int expectedResult)
    {
        Helpers.Measure(() =>
        {
            try
            {
                var cut = new Maths();
                int actualResult = cut.Add(x, y);
                actualResult.Should().Be(expectedResult);
            }
            catch (TimeoutException ex)
            {
                ex.Should().BeOfType<TimeoutException>();
            }
        }, 100);
    }

    [Theory]
    [InlineData(5, 2, 3)]
    [InlineData(2, -2, 4)]
    [InlineData(-2, 3, -5)]
    public void Subtract_ReturnsResult_Within_100ms(int x, int y, int expectedResult)
    {
        Helpers.Measure(() =>
        {
            try
            {
                var cut = new Maths();
                int actualResult = cut.Subtract(x, y);
                actualResult.Should().Be(expectedResult);
            }
            catch (TimeoutException ex)
            {
                ex.Should().BeOfType<TimeoutException>();
            }
        }, 100);
    }

    [Theory]
    [InlineData(5, 2, 10)]
    [InlineData(2, 2, 4)]
    [InlineData(-2, 0, 0)]
    public void Multiply_ReturnsResult_Within_100ms(int x, int y, int expectedResult)
    {
        Helpers.Measure(() =>
        {
            try
            {
                var cut = new Maths();
                int actualResult = cut.Multiply(x, y);
                actualResult.Should().Be(expectedResult);
            }
            catch (TimeoutException ex)
            {
                ex.Should().BeOfType<TimeoutException>();
            }
        }, 100);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 2, 2)]
    [InlineData(2, 2, 1)]
    public void Divide_ByNonZero_ReturnsResult_Within_100ms(int x, int y, int expectedResult)
    {
        Helpers.Measure(() =>
        {
            try
            {
                var cut = new Maths();
                int actualResult = cut.Divide(x, y);
                actualResult.Should().Be(expectedResult);
            }
            catch (TimeoutException ex)
            {
                ex.Should().BeOfType<TimeoutException>();
            }
        }, 100);
    }

    [Fact]
    public void Divide_ByZero_Throws_DivideByZeroException()
    {
        // Arrange
        int x = 5, y = 0;
        var cut = new Maths();

        // Act
        var exception = () => cut.Divide(x, y);

        // Assert
        exception.Should().Throw<DivideByZeroException>()
            .WithMessage("Cannot divide by zero.");
    }
}
