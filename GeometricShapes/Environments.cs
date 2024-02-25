using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Environments
    {
        public double Circle(double radius)
        {
            var p = 3;
            return radius * 2 * p;
        }

        public double Rectangle(double length, double width)
        {
            return (length + width) * 2;
        }

        public double Square(double side)
        {
            return side * 4;
        }

        public double Triangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }
    }
}
