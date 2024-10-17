using Xunit;
using MindboxGeometricShapesLibrary.GeometricShapes;

public class GeometricShapesTests
{
    [Fact]
    public void Triangle_GetArea_ValidSides_ReturnsCorrectArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;
        Assert.Equal(expectedArea, triangle.GetArea(), 0.0001);
    }

    [Fact]
    public void Triangle_InvalidSides_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
    }

    [Fact]
    public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle);
    }

    [Fact]
    public void Triangle_IsRightTriangle_ReturnsFalseForNonRightTriangle()
    {
        Triangle triangle = new Triangle(3, 4, 6);
        Assert.False(triangle.IsRightTriangle);
    }

    [Fact]
    public void Circle_GetArea_ValidRadius_ReturnsCorrectArea()
    {
        Circle circle = new Circle(5);
        double expectedArea = Math.PI * 5 * 5;
        Assert.Equal(expectedArea, circle.GetArea(), 0.0001);
    }

    [Fact]
    public void Circle_InvalidRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}