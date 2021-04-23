using System;
using System.Collections.Generic;
using System.Linq;

namespace Titanic
{
   public class Program
   {
      static void Main(string[] args)
      {
         List<Passenger> passengers = Titanic.GetPassengers("Titanic.Tsv");

            // Intro: The line of code above reads in a file that contains all of
            //        the passengers who were on the Titanic. Feel free to look at
            //        the Passenger class to see which fields each Passenger
            //        contains. The file is read into a List of Passengers.

            // ToDo: Write code using LInQ in order to find the answers to the
            //       following questions.

            // 1) Find out whether a "Miss. Alice Cleaver" survived the accident.
            Passenger alice = passengers.Where(p => p.Name.Contains("Alice") && p.Name.Contains("Cleaver")).FirstOrDefault();
            System.Console.WriteLine(alice);
            // 2) There were six 52-year-olds on board, however, only one embarked
            //    from Cherbourg (C). What was his or her name? Did he or she
            //    survive?
            List<Passenger> fiftyTwos = passengers.FindAll(p => p.Age == 52);
            System.Console.WriteLine(fiftyTwos.Count());
            Passenger fiftyTwoOnBoard = passengers.Where(p => p.Age == 52 && p.Embarked == 'C').FirstOrDefault();
            System.Console.WriteLine(fiftyTwoOnBoard);
            bool didfiftyTwoSurvive = fiftyTwoOnBoard.Survived;
            System.Console.WriteLine(didfiftyTwoSurvive);

            // 3a) How many men were on board?
            List<Passenger> menOnBoard = passengers.FindAll(p => p.Gender == 'M' && p.Age >= 18);
            System.Console.WriteLine(menOnBoard.Count());
            // 3b) How many men survived?
            List<Passenger> menWhoSurvived = menOnBoard.FindAll(p => p.Survived == true);
            System.Console.WriteLine(menWhoSurvived.Count());
            // 3c) What was the survival rate of men?
            System.Console.WriteLine((double)menWhoSurvived.Count() / menOnBoard.Count());

            // ToDo (Hint): Implement the getSurvivalRate method below.

            // 4a) How many women were on board?
            List<Passenger> womenOnBoard = passengers.FindAll(j => j.Gender == 'W' && j.Age >= 18);
            System.Console.WriteLine(womenOnBoard.Count());
            // 4b) How many women survived?
            List<Passenger> womenWhoSurvived = womenOnBoard.FindAll(k => k.Survived == true);
            System.Console.WriteLine(womenWhoSurvived.Count());
            // 4c) What was the survival rate of women?
            System.Console.WriteLine((double)womenWhoSurvived.Count() / womenOnBoard.Count());

            // 5a) How many children were on board?
            List<Passenger> childrenOnBoard = passengers.FindAll(p => p.Age < 18);
            System.Console.WriteLine(childrenOnBoard.Count());
            // 5b) How many children survived?
            List<Passenger> childrenWhoSurvived = childrenOnBoard.FindAll(p => p.Survived == true);
            System.Console.WriteLine(childrenWhoSurvived.Count());
            // 5c) What was the survival rate of children?
            System.Console.WriteLine((double)childrenWhoSurvived.Count() / childrenOnBoard.Count());

            // 6a) Who was the youngest survivor? (name)
            IEnumerable<Passenger> survivors = passengers.FindAll(p => p.Survived == true).OrderBy(p => p.Age).Where(p => p.Age != null);
            Passenger youngest = survivors.First();
            Console.WriteLine(youngest.Name);

            // 6b) Who was the oldest casualty? (name)
            IEnumerable<Passenger> casualties = passengers.FindAll(p => p.Survived == false).OrderBy(p => p.Age).Where(p => p.Age != null);
            Passenger oldestCasualty = casualties.Last();
            Console.WriteLine(oldestCasualty.Name);

            // 7a) Who had the cheapest ticket? (name) Did they survive?
            Passenger cheapestTicket = passengers.OrderBy(p => p.Fare).First();
            Console.WriteLine(cheapestTicket.Name);
            Console.WriteLine(cheapestTicket.Survived);

            // 7b) Who had the most expensive ticket? (name) Did they survive?
            Passenger expensiveTicket = passengers.OrderBy(p => p.Fare).Last();
            Console.WriteLine(expensiveTicket.Name);
            Console.WriteLine(expensiveTicket.Survived);
            // 8a) What was the survival rate for all first class passengers?

            IEnumerable<Passenger> firstClass = passengers.Where(p => p.Class == 1);
            Console.WriteLine(getSurvivalRate(firstClass));
            // 8b) What was the survival rate for all second class passengers?
            IEnumerable<Passenger> secondClass = passengers.Where(p => p.Class == 2);
            Console.WriteLine(getSurvivalRate(secondClass));
            // 8c) What was the survival rate for all third class passengers?
            IEnumerable<Passenger> thirdClass = passengers.Where(p => p.Class == 3);
            Console.WriteLine(getSurvivalRate(thirdClass));
            // 9) What was the survival rate of girls in first class with 2 or
            //    more of any relative?
            IEnumerable<Passenger> girlsInFirstClassWithTwoOrMoreRelatives = passengers.Where(p => p.Class == 1 && p.Gender == 'W' && p.Age < 18 && p.SiblingsSpouse >=2 && p.ParentsChildren >=2);
            Console.WriteLine(getSurvivalRate(girlsInFirstClassWithTwoOrMoreRelatives));

            // 10) What was the survival rate of men in third class with no
            //     relatives onboard?
            IEnumerable<Passenger> MenInThirdClassWithNoRelatives = passengers.Where(p => p.Class == 3 && p.Gender == 'M' && p.Age >= 18 && p.SiblingsSpouse == 0 && p.ParentsChildren == 0);
            Console.WriteLine(getSurvivalRate(MenInThirdClassWithNoRelatives));

            // 11) What was the survival rate of passengers who embarked from
            //     Southampton (S) and whose fare was over 10 pounds?
            IEnumerable<Passenger> southHamptonPlusTen = passengers.Where(p => p.Embarked == 'S' && p.Fare >= 10);
            Console.WriteLine(getSurvivalRate(southHamptonPlusTen));
            // 12) What was the survival rate of passengers with the word "sink"
            //     in their name? (case insensitive)
            IEnumerable<Passenger> wordSink = passengers.Where(p => p.Name.ToUpper().Contains("sink".ToUpper()));
            Console.WriteLine(getSurvivalRate(southHamptonPlusTen));

            // 13) What was the survival rate of passengers whose ticket number
            //     included the substring "13"?
            IEnumerable<Passenger> passengersWithTickerNumberContainingThirteen = passengers.Where(p => p.Ticket.Contains("13"));
            Console.WriteLine(getSurvivalRate(passengersWithTickerNumberContainingThirteen));


        } // end Main( )

        private static double getSurvivalRate(IEnumerable<Passenger> passengers)
      {
         double survivalRate = 0.0;

            survivalRate = (double)passengers.Where(p => p.Survived == true).Count() / passengers.Count();
         // ToDo: Implement this method.

         return survivalRate;
      } // end getSurvivalRate( )
   }
}
