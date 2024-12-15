# Mindbox.Geometry

A library for working with geometric shapes.

## Features

- Supports circles and triangles.
- Calculates the area regardless of the shape type.

## Usage Example

```csharp
var triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Triangle Area: {triangle.EvaluateArea()}");
Console.WriteLine($"Is Right Triangle: {triangle.IsRightAngledTriangle()}");
```