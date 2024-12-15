using System;

namespace Mindbox.Geometry;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException($"All sides: {sideA}, {sideB} and {sideC} must be greater than zero.");
        }

        if (!IsValidTriangle(sideA, sideB, sideC))
        {
            throw new ArgumentException($"The given sides: {sideA}, {sideB} and {sideC} don't form a valid triangle.");
        }

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double EvaluateArea()
    {
        var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
    }

    /// <summary>
    /// Determines whether the triangle is a right-angled triangle.
    /// </summary>
    /// <returns> True if the right-angled triangle; otherwise, false.
    /// </returns>
    /// <remarks>
    /// The method calculates the largest side of the triangle and checks if the sum of the squares 
    /// of the two smaller sides equals the square of the largest side, within a tolerance of 1e-10.
    /// </remarks>
    public bool IsRightAngledTriangle()
    {
        var maxSide = Math.Max(_sideA, Math.Max(_sideB, _sideC));
        return Math.Abs(2 * maxSide * maxSide - (_sideA * _sideA + _sideB * _sideB + _sideC * _sideC)) < 1e-10;
    }

    private static bool IsValidTriangle(double sideA, double sideB, double sideC)
        => sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
}