using System;

namespace lab5MontePi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();
            int iterations = int.Parse(args[0]);
            
            int countA = 0;
            int countB = 0;
            
            for (int i = 0; i < iterations; i++)
            {
                double x;
                double y;
                (x, y) = RandomXY(randomNumberGenerator);
                double c = hypotenuse(x, y);
            
                if (c < 1.0)
                {
                    countA++;
                }
                else
                {
                    countB++;
                }
              
            }
            Console.WriteLine("Values less than 1: " + countB + " : inside the circle");
            Console.WriteLine("Values greater than 1: " + countA + " : outside the circle");

            double myPi = countA / 1000;
            myPi *= 4.0;
            Console.WriteLine(myPi);
            double diff = Math.PI - myPi;
            Console.WriteLine(diff);
        }   

        static (double randomX, double randomY) RandomXY(Random randomPoint)
        {
            //Random randoNum2 = new Random();
            double x = randomPoint.NextDouble();
            //Console.WriteLine(x);
            double y = randomPoint.NextDouble();
            //Console.WriteLine(y);
            //double distance = Math.Sqrt((x * x) + (y * y));  
            //Console.WriteLine(distance);
            return (x, y);
        }
        static double hypotenuse (double x, double y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));
            //Console.WriteLine(distance);
            return distance;
        } 

    }
}
