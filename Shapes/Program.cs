using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Library;
using Shapes.Library.Polygons;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfShapes = new List<Shape>()
            {
                new Square(5),
                new Rectangle(8,4),
                new Triangle(6,5,4),
                new Shape(), //will throw exception when we try to do either calculation.
            };

            foreach (Shape shape in listOfShapes)
            {
                Console.WriteLine($"Area: {shape.CalculateArea()}");
                Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
            }


        }
    }
}
