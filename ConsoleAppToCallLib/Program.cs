using MindboxGeometricShapesLibrary.GeometricShapes;
using MindboxGeometricShapesLibrary.Interfaces;

namespace MindboxGeometricShapesLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var shape in new IGetArea[] {
                new Circle(42),
                new Triangle(3, 5, 4),
                new Triangle(3, 5, 6)
            })
            {
                Console.WriteLine($"Площадь {shape.GetType().Name} = {shape.GetArea()}");
                if (shape is Triangle triangle)
                {
                    if (triangle.IsRightTriangle)
                        Console.WriteLine($"{shape.GetType().Name} правильный (есть угол 90°)");
                    else
                        Console.WriteLine($"{shape.GetType().Name} не правильный (нет угла 90°)");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
