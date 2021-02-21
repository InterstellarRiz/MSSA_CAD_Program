using System;

namespace LabCh._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bullet1();
            Bullet2();
        }

        private static int Bullet1()
        {
            int userInput = 0;
            bool commit = false;
            while (commit == false)
            {
                try
                {
                    Console.WriteLine("Please enter an integer: ");
                    userInput = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your input was: {userInput}");
                    commit = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine("You did not use an integer!");
                    Console.WriteLine(e.Message);
                }
            }
            return userInput;
        }


        private static double Bullet2()
        {
            double userInput = 0;
            bool commit = false;
            while (commit == false)
            {
                try
                {
                    Console.WriteLine("Please enter a double: ");
                    userInput = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Your input was: {userInput}");
                    commit = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("You did not use a double!");
                    Console.WriteLine(e.Message);
                }
            }
            return userInput;
        }

    }
}


