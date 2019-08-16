using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    public class StaticCircle
    {
        public const double Pi = 3.14;
        public static double GetArea(double radius)
        {
            radius = Math.Abs(radius);
            return Pi * radius * radius;
        }
        public static double GetLength(double radius)
        {
            return Pi * Math.Abs(radius) * 2;
        }
    }
}
