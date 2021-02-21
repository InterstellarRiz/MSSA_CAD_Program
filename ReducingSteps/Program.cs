using System;

namespace ReducingSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberOfSteps(14);
            NumberOfSteps(8);
            NumberOfSteps(123);
        }

        static void NumberOfSteps(int num)
        {
            int stepNumbers = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    stepNumbers++;
                }
                else
                {
                    num -= 1;
                    stepNumbers++;
                }
            }
            Console.WriteLine(stepNumbers);
        }
    }
}
