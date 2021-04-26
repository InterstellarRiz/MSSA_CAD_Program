using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Calculator
    {
        //field & prop
        public int CurrentValue { get; set; }


        // constructors
        public Calculator()
        {
            CurrentValue = 0;
        }

        public Calculator(int currentValue)
        {
            CurrentValue = currentValue;
        }

        //Method
        public static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();

            //Console.WriteLine(myCalculator.Add(24));
            //Console.WriteLine(myCalculator.Multiply(2));
            //Console.WriteLine(myCalculator.Divide(3));
            //Console.WriteLine(myCalculator.Reset());
            //Console.WriteLine(myCalculator.Add(5));
            //Console.WriteLine(myCalculator.ComputeToThePowerOf(3));
            //Console.WriteLine(myCalculator.Reset());
            //Console.WriteLine(myCalculator.Add(3));
            //Console.WriteLine(myCalculator.ComputeFactorialOf());
            myCalculator.isPrime(1000000000);

        }

        public int Reset()
        {
            CurrentValue = 0;

            return CurrentValue;
        }

        public int ComputeToThePowerOf(int powerValue) // 3
        {
            int baseValue = CurrentValue;

            for (int i = 1; i < powerValue; i++) //25 , 125,
            {

                CurrentValue *= baseValue;
            }

            return CurrentValue;

        }

        public int Add(int valueToAdd)
        {
            CurrentValue += valueToAdd;

            return CurrentValue;
        }

        public int ComputeFactorialOf()
        {
            //decrease the currentvalue by 1 
            // multiply it by the value
            for (int i = CurrentValue - 1; i > 0; i--) //3
            {
                CurrentValue *= i; // 3 * 2 = 6, 6
            }

            return CurrentValue;
            

        }

        public int Multiply(int valueToMulti)
        {
            CurrentValue *= valueToMulti;

            return CurrentValue;
        }

        public int Divide(int valueToDiv)
        {

            CurrentValue /= valueToDiv;

            return CurrentValue;
        }
        public bool isPrime(int valueToCheck)
        {
            //see is the number is only divisble by itself Ex. 13, 19
            //if any number prior to the number returns a number that does not have a decimal then it is not prime 
            if (valueToCheck % 2 == 0)
            {
                Console.WriteLine(false);
                return false;
            }
            if (valueToCheck % 5 == 0)
            {
                Console.WriteLine(false);
                return false;
            }
            
            for (int i = 3; i <= Math.Sqrt(valueToCheck); i+=2) //
            {
                if (valueToCheck % i == 0) //
                {
                    Console.WriteLine(false);
                    return false;
                }
            }
            Console.WriteLine(true);
            return true;

        }


    }
}
