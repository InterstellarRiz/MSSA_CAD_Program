using System;

namespace GeometricAreas_Perimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double circle1Radius = 1.0;
            double circle1Area = GetArea(circle1Radius); // 3.14159...
            double circle1Perimeter = GetPerimeter(circle1Radius); // 6.28318...
            Console.WriteLine("Circle 1      Area: " + circle1Area);
            Console.WriteLine("Circle 1 Perimeter: " + circle1Perimeter);
            Console.WriteLine();

            double rectangleLength = 2.0;
            double rectangleWidth = 3.0;
            double rectangleArea = GetArea(rectangleLength, rectangleWidth);
            double rectanglePerimeter = GetPerimeter(rectangleLength, rectangleWidth);
            Console.WriteLine("Rectangle      Area: {0}", rectangleArea);
            Console.WriteLine("Rectangle Perimeter: {0}", rectanglePerimeter);
            Console.WriteLine();

            double triangleSideA = 4.0;
            double triangleSideB = 5.0;
            double triangleSideC = 6.0;
            double triangleArea = GetArea(triangleSideA, triangleSideB, triangleSideC);
            double trianglePerimeter = GetPerimeter(triangleSideA, triangleSideB, triangleSideC);
            Console.WriteLine($"Triangle      Area: {triangleArea}");
            Console.WriteLine($"Triangle Perimeter: {trianglePerimeter}");
            Console.WriteLine();

            (circle1Area, circle1Perimeter) = GetAreaAndPerimeter(1.0);
            Console.WriteLine($"Circle 1      Area: {circle1Area}");
            Console.WriteLine($"Circle 1 Perimeter: {circle1Perimeter}");
            Console.WriteLine();
        }

        static double GetArea(double radius) // Circle
        {
            double area = Math.PI * (radius * radius);
            return area;
        }

        static double GetArea(double length, double width) // Rectangle
        {
            double area = length * width;
            return area;
        }

        static double GetArea(double a, double b, double c) // Triangle
        {
            double s = ((a + b + c) / 2);
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static double GetPerimeter(double radius) // Circle
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }

        static double GetPerimeter(double length, double width) // Rectangle
        {
            double perimeter = (2 * length) + (2 * width);
            return perimeter;
        }

        static double GetPerimeter(double a, double b, double c) // Triangle
        {
            double perimeter = a + b + c;
            return perimeter;
        }

        static (double area, double perimeter) GetAreaAndPerimeter(double radius) // Circle
        {
            double area = Math.PI * (radius * radius);
            double perimeter = 2 * Math.PI * radius;
            return (area, perimeter);

        }

        static (double area, double perimeter) GetAreaAndPerimeter(double length, double width) // Rectangle
        {
            double area = length * width;
            double perimeter = (2 * length) + (2 * width);
            return (area, perimeter);
        }

        static (double area, double perimeter) GetAreaAndPerimeter(double a, double b, double c) // Triangle
        {
            double s = ((a + b + c) / 2);
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            double perimeter = a + b + c;
            return (area, perimeter);
        }

    }
}