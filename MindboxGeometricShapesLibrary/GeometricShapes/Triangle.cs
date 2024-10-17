using MindboxGeometricShapesLibrary.Interfaces;

namespace MindboxGeometricShapesLibrary.GeometricShapes;

public class Triangle : IGetArea
{
    public double SideALength { get; }
    public double SideBLength { get; }
    public double SideCLength { get; }
    public bool IsRightTriangle { get; }

    public Triangle(double sideALength, double sideBLength, double sideCLength)
    {
        if (sideALength <= 0 || sideBLength <= 0 || sideCLength <= 0)
        {
            throw new ArgumentException("Длины сторон должны быть положительными.");
        }

        if (sideALength + sideBLength <= sideCLength ||
            sideALength + sideCLength <= sideBLength ||
            sideBLength + sideCLength <= sideALength)
        {
            throw new ArgumentException("Треугольник с такими сторонами невозможен.");
        }

        SideALength = sideALength;
        SideBLength = sideBLength;
        SideCLength = sideCLength;

        IsRightTriangle = CheckIsRightTriangle();
    }

    private bool CheckIsRightTriangle()
    {
        // Сортируем стороны для упрощения проверки
        double[] sides = { SideALength, SideBLength, SideCLength };
        Array.Sort(sides);

        // Проверяем теорему Пифагора с учетом погрешности
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 0.0001;
    }

    public double GetArea()
    {
        // Используем формулу Герона для вычисления площади
        double semiPerimeter = (SideALength + SideBLength + SideCLength) / 2;
        return Math.Sqrt(semiPerimeter *
                         (semiPerimeter - SideALength) *
                         (semiPerimeter - SideBLength) *
                         (semiPerimeter - SideCLength));
    }
}
