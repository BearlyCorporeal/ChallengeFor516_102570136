using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClassLibrary
{
    public class Rectangle : Quadrilateral
    {
        
        public Rectangle(string color, int side1Length, int side2Length) : base(side1Length, side2Length, color)
        {
          
        }
        public override int GetPerimeter()
        {
            return side1Length + side1Length + side2Length + side2Length;
        }
        public int GetArea()
        {
            return side1Length * side2Length;
        }

    }
}
