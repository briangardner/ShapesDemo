using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library
{
    public class Shape
    {
        public virtual double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
