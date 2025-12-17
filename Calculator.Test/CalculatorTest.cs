using Xunit;

namespace Calculator.Test;

public class CalculatorTest
{
    private readonly Calculate _calculator = new Calculate();

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(10, 20, 30)]
    [InlineData(-5, 5, 0)]
    public void Add_ReturnsCorrectSum(int a, int b, int expected)
    {
        var result = _calculator.Add(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(10, 20, -10)]
    [InlineData(10, 0, 10)]
    public void Subtract_ReturnsCorrectDifference(int a, int b, int expected)
    {
        var result = _calculator.Subtract(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(5, -2, -10)]
    [InlineData(0, 100, 0)]
    public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
    {
        var result = _calculator.Multiply(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(10, 2, 5)]
    // Note: Be careful with integer division if your calculator uses ints
    // 5 / 2 might return 2 if integer math is used
    [InlineData(20, 5, 4)]
    public void Divide_ReturnsCorrectQuotient(int a, int b, int expected)
    {
        var result = _calculator.Divide(a, b);
        Assert.Equal(expected, result);
    }
}