using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Lab12_Inheritance
{
    public class Rectangle : Shapes
    {
        private double length = 1.0;
        private double width = 1.0;
        public Rectangle(double length, double width)
        {
            SetDimensions(length, width);
        }
        public Rectangle(string color) : base(color)
        {

        }
        public double GetArea()
        {
            return length * width;
        } 
        public double GetPerimeter()
        {
            return (length + width) * 2;
        } 
        public double GetLength()
        {
            return length;
        } 
        public void SetLength(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
        } 
        public double GetWidth()
        {
            return width;
        } 
        public void SetWidth(double width)
        {
            if (width > 0)
            {
                this.width = width;
            }
        }
        public (double l, double w) GetDimensions()
        {
            return (length, width);
        }
        public void SetDimensions(double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        } 
    }
}

