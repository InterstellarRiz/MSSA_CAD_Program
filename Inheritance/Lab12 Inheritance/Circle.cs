using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Inheritance
{
    public class Circle : Shapes
    {
        private double radius = 1.0;
        public Circle(double radius)
        {
            SetRadius(radius);
        }
        public Circle(string color) : base(color)
        {

        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        } // end GetArea( )
        public double GetCircumference()
        {
            return 2.0 * Math.PI * radius;
        }
        public double GetRadius()
        {
            return radius;
        } // end GetRadius( )
        public void SetRadius(double radius)
        {
            if (radius > 0.0)
            {
                this.radius = radius;
            }
        } 
    }
}
