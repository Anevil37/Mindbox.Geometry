using FluentAssertions;

namespace Mindbox.Geometry.Tests;

public class CircleTests
{
    [Fact]
    public void Circle_EvaluateAre_ShouldReturnCorrectValue()
    {
        // Arrange
        var circle = new Circle(4);

        // Act
        var result = circle.EvaluateArea();

        // Assert
        result.Should().Be(Math.PI * 16);
    }

    [Fact]
    public void Circle_ShouldThrowArgumentException()
    {
        // Act & Assert 
        Assert.Throws<ArgumentException>(() => new Circle(-100));
    }
}