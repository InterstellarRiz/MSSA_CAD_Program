using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square
    {
        private double side = 1;
        public Square(double side1)
        {
            side = side1;
        }
        public double GetArea() => 2 * side;
        public double GetPerimeter() => side * 4;
        public double GetSide() => side;
        public void Setside(double side)
        {

            if (side < 0)
            {
                side = -side;
            }
            else if (side == 0)
            {
                side = 1;
            }
            this.side = side;
        }

    }
}
