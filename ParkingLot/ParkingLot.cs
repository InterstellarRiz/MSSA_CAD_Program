using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public class ParkingLot
    {    // building fields to hold the type of cars
        private double _numofLargespaces { get; set; }
        private double _numofMediumspaces { get; set; }
        private double _numofSmallspaces { get; set; }

        // does this need to be a string or double ... someone is calling this constructor and inputing the number of spaces 
        public ParkingLot(double numofLargespaces, double numofMediumspaces, double numofSmallspaces) // requires caller to speciffy how many of each kind of car the parking lot holds
        {
            _numofLargespaces = numofLargespaces;
            _numofMediumspaces = numofMediumspaces;      // store the spaces in the fields
            _numofSmallspaces = numofSmallspaces;
        }
        // they will call the method to try and put a car in the parking lot
        public bool AddCar(string carType)
        {
            string _carType = carType.ToLower();
            bool isThereSpace = true;

            if (_carType == "large")
            {
                // I want to take the string from the user... look at the # of large spaces... if value is < spaces then yes there is room ... subtract value from space and so on
                //
                if (_numofLargespaces > 0)
                {
                    _numofLargespaces -= 1;
                    return isThereSpace = true;
                }
                else
                {
                    return isThereSpace = false;
                }
            }
            if (_carType == "medium")
            {
                // I want to take the string from the user... look at the # of large spaces... if value is < spaces then yes there is room ... subtract value from space and so on
                //
                if (_numofMediumspaces > 0)
                {
                    _numofMediumspaces -= 1;
                    return isThereSpace = true;
                }
                else
                {
                    return isThereSpace = false;
                }
            }
            if (_carType == "small")
            {
                // I want to take the string from the user... look at the # of large spaces... if value is < spaces then yes there is room ... subtract value from space and so on
                //
                if (_numofSmallspaces > 0)
                {
                    _numofSmallspaces -= 1;
                    return isThereSpace = true;
                }
                else
                {
                    return isThereSpace = false;
                }
            }
            return isThereSpace;
        }
        public double GetLargeSpace()
        {
            return _numofLargespaces;
        }
        public double GetMediumSpace()
        {
            return _numofMediumspaces;
        }
        public double GetSmallSpace()
        {
            return _numofSmallspaces;
        }
    }

    
}
