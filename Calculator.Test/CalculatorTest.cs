namespace Calculator.Test;

public class CalculatorTest
{
    private readonly Calculate _calculator = new Calculate();

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var result = _calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        var result = _calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        var result = _calculator.Multiply(2, 3);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Divide_ReturnsCorrectQuotient()
    {
        var result = _calculator.Divide(6, 3);
        Assert.Equal(2, result);
    }
}