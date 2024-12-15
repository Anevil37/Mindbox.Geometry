namespace Mindbox.Geometry;

public static class AreaCalculator
{
    /// <summary>
    /// Evaluates the area of the given shape.
    /// </summary>
    /// <param name="shape">The type of geometric shape.</param>
    /// <returns>The area of the shape as a double.</returns>
    public static double Evaluate(IShape shape)
        => shape.EvaluateArea();

    /// <summary>
    /// Attempts to evaluate the area of the given shape. Returns a boolean indicating success or failure.
    /// </summary>
    /// <param name="shape">The type of geometric shape.</param>
    /// <param name="value"> When the method returns, contains the evaluated area of the shape if successful, or 0 if an exception occurs.</param>
    /// <returns> True if the evaluation succeeds; otherwise, false.</returns>
    public static bool TryEvaluate(IShape shape, out double value)
    {
        try
        {
            value = Evaluate(shape);
            return true;
        }
        catch
        {
            value = 0;
            return false;
        }
    }
}