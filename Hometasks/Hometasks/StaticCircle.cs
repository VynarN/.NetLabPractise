using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask1
{
    class StaticCircle
    {
        public const double Pi = 3.14;
        public static double GetArea(double radius)
        {
            return Pi * radius * radius;
        }
        public static double GetLength(double radius)
        {
            return Pi * radius * 2;
        }
    }
}
