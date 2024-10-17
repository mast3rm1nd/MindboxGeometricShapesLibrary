using MindboxGeometricShapesLibrary.Interfaces;

namespace MindboxGeometricShapesLibrary.GeometricShapes;

public class Circle : IGetArea
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положительным.");
        }

        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
