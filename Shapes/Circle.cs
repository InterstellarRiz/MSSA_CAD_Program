using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle
    {
        private double radius = 1;

        public Circle(double r)
        {
            radius = r;
        }
        public double GetArea() => Math.PI * (radius * radius);
        public double GetCircumference() => 2 * Math.PI * radius;
        public double GetRadius() => radius;
        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                radius = -radius;
            }
            else if (radius == 0)
            {
                radius = 1;
            }
            this.radius = radius;
        }
    }
}
