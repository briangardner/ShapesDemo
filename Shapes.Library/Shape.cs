using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library
{
    public abstract class Shape
    {
        protected Shape(string name)
        {
            Name = name;
        }
        protected string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();
    }
}
