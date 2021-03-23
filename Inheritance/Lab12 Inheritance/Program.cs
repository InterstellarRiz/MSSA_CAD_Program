using System;

namespace Lab12_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle rightT = new Triangle(12, 24, 35, "green");
            Console.WriteLine(rightT.GetPerimeter());
            Console.WriteLine(rightT.GetArea());
            rightT.SetColor("Blue");
            Console.WriteLine(rightT.GetColor());
        }
    }
}
