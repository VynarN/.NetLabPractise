using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    public class Circle
    {
        public const double Pi = 3.14;
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Pi * Radius * Radius;
        }
        public double GetLength()
        {
            return Pi * Radius * 2;
        }
    }
}
