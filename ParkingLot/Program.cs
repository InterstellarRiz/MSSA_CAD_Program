using System;


namespace ParkingLot
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Parking Lot!");
            Console.WriteLine("This parking lot consist of spaces for : Large, Medium, and Small vehicles.");
            ParkingSpaceQuestion();
        }

        public static void ParkingSpaceQuestion()
        {
            ParkingLot alpha = new ParkingLot(5, 5, 5);
            bool loop = false;
            while (loop == false)

            {
                Console.WriteLine("What type of car are you trying to park: ");
                string _answer = Console.ReadLine();
                string answer = _answer.ToLower();
                if (answer == "large" || answer == "medium" || answer == "small")
                {
                    alpha.AddCar(answer);
                    //Console.WriteLine("Anymore cars (yes or no)? ");
                   // string _answer2 = Console.ReadLine();
                   // string answer2 = _answer2.ToLower();
                   // if (answer2 == "yes")
                   // {
                   //     ParkingSpaceQuestion();
                   //     alpha.AddCar(answer);
                   // }
                   // else
                   // {
                   //     loop = true;
                   // }
                    loop = true;
                }
                else
                {
                    Console.WriteLine("You did not enter: Large, Medium, or Small \n Please try again");
                    loop = false;
                }
            }
            double largeParking;
            double mediumParking;
            double smallParking;

            largeParking = alpha.GetLargeSpace();
            mediumParking = alpha.GetMediumSpace();
            smallParking = alpha.GetSmallSpace();

            Console.WriteLine($"There are {largeParking} large parking spaces left.\n\t There are {mediumParking} medium parking spaces left.\n\t\t There are {smallParking} small parking spaces left.");
        }
    }
}
