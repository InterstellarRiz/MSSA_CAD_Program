using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle
    {
        private double sideA = 1;
        private double sideB = 2;
        private double sideC = 3;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public double GetArea()
        {
            double herons = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(herons * (herons - sideA) * (herons - sideB) * (herons - sideC));
            return area;
        }
        public double GetPerimeter()
        {
            double perimeter = sideA + sideB + sideC;
            return perimeter;
        }
        public double GetSideA() => sideA;
        public double GetSideB() => sideB;
        public double GetSideC() => sideC;
        public void SetSideA(double sideA)
        {
            if (sideA < 0)
            {
                sideA = -sideA;
            }
            else if (sideA == 0)
            {
                sideA = 1;
            }
            this.sideA = sideA;
        }
        public void SetSideB(double sideB)
        {
            if (sideB < 0)
            {
                sideB = -sideB;
            }
            else if (sideB == 0)
            {
                sideB = 1;
            }
            this.sideB = sideB;
        }
        public void SetSideC(double sideC)
        {
            if (sideC < 0)
            {
                sideC = -sideC;
            }
            else if (sideC == 0)
            {
                sideC = 1;
            }
            this.sideC = sideC;
        }

    }
}
