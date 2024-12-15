namespace Mindbox.Geometry;

public interface IShape
{
    /// <summary>
    /// Evaluates the shape area.
    /// </summary>
    /// <returns> The area of the shape as a double.</returns>
    public double EvaluateArea();
}