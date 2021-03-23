﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Inheritance
{
    public class Triangle : Shapes
    {
        //   F i e l d s

        private double a = 1.0;
        private double b = 1.0;
        private double c = 1.0;

        //   C o n s t r u c t o r s

        public Triangle(double a, double b, double c, string color) : base(color)
        {
            SetSides(a, b, c);
            SetColor(color);
            
        }
        
        // end Triangle( )

        //   M e t h o d s

        public double GetArea()   // Heron's Formula
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        } // end GetArea( )

        public double GetPerimeter()
        {
            return a + b + c;
        } // end GetPerimeter( )

        public double GetSideA()
        {
            return a;
        } // end GetSideA( )

        public double GetSideB() //Get Side B
        {
            return b;
        } // end GetSideB( )

        public double GetSideC()
        {
            return c;
        } // end GetSideC( )

        public (double a, double b, double c) GetSides()
        {
            return (a, b, c);
        }

        public void SetSides(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }// end of SetSides( )
    }
}
