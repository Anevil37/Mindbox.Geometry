using System;

namespace Mindbox.Geometry;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException($"Radius: {radius} less than zero.", nameof(radius));
        }

        _radius = radius;
    }

    public double EvaluateArea() => Math.PI * _radius * _radius;
}