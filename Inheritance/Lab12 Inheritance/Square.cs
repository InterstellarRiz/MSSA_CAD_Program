using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Inheritance
{
    public class Square : Shapes
    {
        private double side = 1.0;
        public Square(double side)
        {
            SetSide(side);
        }
        public Square(string color) : base(color)
        {

        }
        public double GetArea() => side * side;
        public double GetPerimeter() => 4 * side;
        public double GetSide() => side;
        public void SetSide(double side)
        {
            if (side > 0)
            {
                this.side = side;
            }
        }
    }
}
