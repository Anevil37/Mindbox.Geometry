using FluentAssertions;

namespace Mindbox.Geometry.Tests;

public class AreaCalculatorTests
{
    [Theory]
    [MemberData(nameof(ShapeWithAre))]
    public void AreaCalculator_Evaluate_ShouldReturnCorrectValueDependsOnShape(IShape shape, double expected)
    {
        // Act
        var result = AreaCalculator.Evaluate(shape);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(ShapeWithAre))]
    public void AreaCalculator_TryEvaluate_ShouldReturnTrueWithCorrectValueDependsOnShape(IShape shape, double expected)
    {
        // Act
        var result = AreaCalculator.TryEvaluate(shape, out var value);

        // Assert
        result.Should().Be(true);
        value.Should().Be(expected);
    }

    [Fact]
    public void AreaCalculator_TryEvaluate_ShouldReturnFalseWithZeroDependsOnShape()
    {
        // Act
        var result = AreaCalculator.TryEvaluate(new InvalidShape(), out var value);

        // Assert
        result.Should().Be(false);
        value.Should().Be(0);
    }

    public static IEnumerable<object?[]> ShapeWithAre => new List<object?[]>
    {
        new object?[] {new Circle(5), Math.PI * 25},
        new object[] {new Triangle(3, 4, 5), 6},
    };

    private class InvalidShape : IShape
    {
        public double EvaluateArea() => throw new InvalidOperationException("Invalid shape");
    }
}