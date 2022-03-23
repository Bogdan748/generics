using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGenerics
{
    public static class ShapeCalculator
    {

        public static double SumAreas(IEnumerable<Shape> shapes)
        {
            double sum = 0;
                foreach(Shape shape in shapes)
            {
                sum += shape.Area;
            }

            return sum;
        }
    }
}
