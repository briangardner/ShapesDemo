using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library
{
    public class Rectangle : Shape
    {
        public int SideLength { get; set; }
        public int Side2Length { get; set; }

        public Rectangle(int side1Length, int side2Length)
        {
            SideLength = side1Length;
            Side2Length = side2Length;
        }

        public override double CalculateArea()
        {
            return SideLength * Side2Length;
        }

        public override double CalculatePerimeter()
        {
            return (SideLength * 2) + (Side2Length * 2);
        }
    }
}
