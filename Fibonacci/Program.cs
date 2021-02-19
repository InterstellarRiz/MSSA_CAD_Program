using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 0;
            int value2 = 1;

            Console.WriteLine(value1);
            Console.WriteLine(value2);

            for (int i = 0; i < 18; i++)
            {
                int value3 = value1 + value2;
                Console.WriteLine(value3);

                value1 = value2;
                value2 = value3;
            }
        }
    }
}
