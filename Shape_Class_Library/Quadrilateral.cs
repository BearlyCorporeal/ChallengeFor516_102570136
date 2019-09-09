using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClassLibrary
{
    public abstract class Quadrilateral : Shape
    {
        public int side1Length;
        public int side2Length;
        public int side3Length;
        public int side4Length;
        abstract public int GetPerimeter();
        
        public Quadrilateral(int side1Length, int side2Length, string colour) : base(colour)
        {
            this.side1Length = side1Length;
            this.side2Length = side2Length;
            
        }
        public Quadrilateral(int side1Length, string colour) : base(colour)
        {
            this.side1Length = side1Length;
            
        }
    }
}
