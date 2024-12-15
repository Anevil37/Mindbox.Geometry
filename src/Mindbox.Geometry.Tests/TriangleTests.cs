using FluentAssertions;

namespace Mindbox.Geometry.Tests;

public class TriangleTests
{
    [Fact]
    public void Triangle_EvaluateArea_ShouldReturnCorrectValue()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.EvaluateArea();
        
        // Assert
        result.Should().Be(6);
    }
    
    [Theory]
    [InlineData(0, 2, 3)]
    [InlineData(1, -1, 3)]
    [InlineData(1, 2, -35.3)]
    [InlineData(0.1, 0.1, 100)]
    [InlineData(0.1, 100, 0.1)]
    [InlineData(100, 0.1, 0.1)]
    public void Triangle_ShouldThrowArgumentException(double sideA, double sideB, double sideC)
    {
        // Act & Assert 
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 4, 6, false)]
    public void Triangle_IsRightTriangle_ShouldReturnCorrectResult(double sideA, double sideB, double sideC, bool expected)
    {
        // Arrange
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        var result = triangle.IsRightAngledTriangle();
        
        // Assert
        result.Should().Be(expected);
    }
}