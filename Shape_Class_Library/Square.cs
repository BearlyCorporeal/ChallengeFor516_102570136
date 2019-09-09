using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClassLibrary
{
    public class Square : Quadrilateral
    {
        public Square(string color, int side1Length) : base(side1Length, color)
        { 
        }
        public int GetArea()
        {
            return side1Length * side1Length;
        }
        public override int GetPerimeter()
        {
            return side1Length * 4;
        }
    }
}
