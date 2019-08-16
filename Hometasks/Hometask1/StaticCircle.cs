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
            return Pi * Math.Abs(radius) * radius;
        }
        public static double GetLength(double radius)
        {
            return Pi * Math.Abs(radius) * 2;
        }
    }
}
