using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Inheritance
{
    public class Shapes
    {
        private string color;

        public Shapes()
        {

        }
        public Shapes(string _color)
        {
            this.color = _color;
        }
        public void SetColor(string _color)
        {
            color = _color;
        }

        public string GetColor()
        {
            return color;
        }
    }
}
