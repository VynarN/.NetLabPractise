using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    public class StaticRectangle
    {
        public static double GetArea((double, double) top_left, (double, double) bottom_right)
        {
            if (top_left.Item2 < bottom_right.Item2 ||
               bottom_right.Item1 < top_left.Item1)
            {
                Console.WriteLine("Invalid coordinates!");
                return 0;
            }
            double width = Math.Abs(top_left.Item2) - Math.Abs(bottom_right.Item2);
            double length = Math.Abs(bottom_right.Item1) - Math.Abs(top_left.Item1);
            return width * length;
        }
        public static double GetPerimeter((double, double) top_left, (double, double) bottom_right)
        {
            if (top_left.Item2 < bottom_right.Item2 ||
               bottom_right.Item1 < top_left.Item1)
            {
                Console.WriteLine("Invalid coordinates!");
                return 0;
            }
            double width = Math.Abs(top_left.Item2) - Math.Abs(bottom_right.Item2);
            double length = Math.Abs(bottom_right.Item1) - Math.Abs(top_left.Item1);
            return (width + length) * 2;
        }
    }
}
