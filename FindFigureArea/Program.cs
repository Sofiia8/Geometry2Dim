using System;
using FigureAreaLibrary;

namespace FindFigureArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGeometryFigure geometryFigure;
            Console.WriteLine("Input 1 - to have a circle\n2 - to have a triangle");
            if (!int.TryParse(Console.ReadLine(), out int res))
            {
                Console.WriteLine("Input isn't correct!");
                return;
            }
            if (res == 1)
            {
                Console.WriteLine("Let's set a circle. Input radius:");
                if (!Double.TryParse(Console.ReadLine(), out double radius))
                {
                    Console.WriteLine("Input isn't correct!");
                    return;
                }
                try
                {
                    geometryFigure = new Circle(radius);
                    Console.WriteLine($"Area of this figure is equal to {geometryFigure.GetArea()}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (res == 2)
            {
                Console.WriteLine("Let's set a triangle. Input side A:");
                if (!Double.TryParse(Console.ReadLine(), out double sideA))
                {
                    Console.WriteLine("Input isn't correct!");
                    return;
                }
                Console.WriteLine("Input side B:");
                if (!Double.TryParse(Console.ReadLine(), out double sideB))
                {
                    Console.WriteLine("Input isn't correct!");
                    return;
                }
                Console.WriteLine("Let's set a triangle. Input side C:");
                if (!Double.TryParse(Console.ReadLine(), out double sideC))
                {
                    Console.WriteLine("Input isn't correct!");
                    return;
                }
                try
                {
                    geometryFigure = new Triangle3S(sideA, sideB, sideC);
                    Console.WriteLine($"Area of this figure is equal to {geometryFigure.GetArea()}.");
                    Console.WriteLine($"This triangle is right: {(geometryFigure as Triangle3S)?.IsRightTriangle}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!");
                }
            }
            return;
        }
    }
}