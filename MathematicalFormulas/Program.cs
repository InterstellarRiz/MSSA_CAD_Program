using System;

namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
             // Partially worked example
            Console.WriteLine("Circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            double doubleRadius = double.Parse(strradius);
            double circumference = Math.Round(2 * (Math.PI * doubleRadius), 2);
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.Round(Math.PI * (doubleRadius * doubleRadius), 2);
            Console.WriteLine($"The area is {area}");
             
             
            Console.WriteLine("Part 2, volume of a hemisphere.");
            Console.WriteLine("Enter a positive integer for the radius: ");
            string volradius = Console.ReadLine();
            double hemradius = double.Parse(volradius);
            double volume = Math.Round(Math.PI * 4 / 3 * Math.Pow(hemradius, 3), 2) / 2;
            Console.WriteLine($"The volume of a hemisphere is {volume}");
                                              
            //Part 3

            Console.WriteLine("Part 3, area of a triangle (Heron's formula).");
            Console.WriteLine("Enter a: ");
            double alpha = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double beta = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            double charlie = double.Parse(Console.ReadLine());
            double papa = (alpha + beta + charlie) / 2;
            double triArea = Math.Sqrt(papa * (papa - alpha) * (papa - beta) * (papa - charlie));
            Console.WriteLine($"The area of triangle = {triArea}");
            

            // Part 4
            Console.WriteLine("Part 4, solving a quadratic equation.");
            Console.WriteLine("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            double innerEquation = Math.Pow(b, 2) - (4 * a * c);
            double upperSection1 = (-b - (Math.Sqrt(innerEquation)));
            double lowsection = 2 * a;

            double upperSection2 = (-b + (Math.Sqrt(innerEquation)));

            double result1 = upperSection1 / lowsection;

            double result2 = upperSection2 / lowsection;

            Console.WriteLine($"The two results are: {result1} , {result2}");



            // double x = Math.Round((-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a), 2);
            // 
            // double newx = Math.Round((-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a), 2);
            // 
            // Console.WriteLine($"The two values are: {x} and {newx} ");
        }

    }
}