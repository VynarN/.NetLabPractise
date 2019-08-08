using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask1
{
    class Circle
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
