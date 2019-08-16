using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    public class Rectangle
    {
        public double Width { get; }
        public double Length { get; }
        public Rectangle((double, double) top_left, (double, double) bottom_right)
        {
            /*checking the validity of the coordinates:
              Y of the left coordinate can not be smaller
              than Y of the rigth one as well as X of
              the rigth coordinate can not be smaller
              than X of the left one */
            
            if (top_left.Item2 < bottom_right.Item2 ||
                bottom_right.Item1 < top_left.Item1)
            {
                Console.WriteLine("Invalid coordinates!");
                Width = 0;
                Length = 0;
            }
            else
            {
                //<turple>.Item1 - X, <turple>.Item2 - Y
                // find out a width and a length of the rect via given coordinates
                Width = Math.Abs(top_left.Item2) - Math.Abs(bottom_right.Item2);
                Length = Math.Abs(bottom_right.Item1) - Math.Abs(top_left.Item1);
            }
        }
        public double GetArea()
        {
            return Width * Length;
        }
        public double GetPerimeter()
        {
            return (Width + Length) * 2;
        }
    }
}
