using System;
using Shapes;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(5);

            double area = square1.GetArea();
            Console.WriteLine(area);
            double perimeter = square1.GetPerimeter();
            Console.WriteLine(perimeter);
            square1.Setside(15);
            double sideValue = square1.GetSide();
            Console.WriteLine(sideValue);

            Circle circle1 = new Circle(2);

            double areaCircle = circle1.GetArea();
            Console.WriteLine(areaCircle);
            double circumferenceCircle = circle1.GetCircumference();
            Console.WriteLine(circumferenceCircle);
            circle1.SetRadius(15);
            double radiusValue = circle1.GetRadius();
            Console.WriteLine(radiusValue);

            Triangle triangle1 = new Triangle(2, 3, 5);
           
            double areatriangle = triangle1.GetArea();
            Console.WriteLine(areatriangle);
            double perimetertriangle = triangle1.GetPerimeter();
            Console.WriteLine(perimetertriangle);
            triangle1.SetSideA(10);
            Console.WriteLine(triangle1.GetSideA());


        }
    }
}
