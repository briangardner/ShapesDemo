using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library
{
    public class Triangle : Shape
    {
        public Triangle(int side1, int side2, int side3)
        {
            Side1Length = side1;
            Side2Length = side2;
            Side3Length = side3;

            if ((Side1Length + Side2Length) <= Side3Length ||
                (Side1Length + Side3Length) <= Side2Length ||
                (Side2Length + Side3Length) <= Side1Length)
            {
                throw new Exception("Not a Triangle!");
            }
        }

        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }

        public override double CalculatePerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }

        public override double CalculateArea()
        {
            var s = (double) CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - Side1Length) * (s - Side2Length) * (s - Side3Length));
        }


    }
}
