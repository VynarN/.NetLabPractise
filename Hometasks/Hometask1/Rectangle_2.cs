using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    public class Rectangle_2
    {
        public double Width { get; }
        public double Length { get; }
        public double GetArea
        {
            get
            {
                return Width * Length;
            }
        }
        public double GetPerimeter
        {
            get
            {
                return (Width + Length) * 2;
            }
        }
        public Rectangle_2((double, double) top_left, (double, double) bottom_right)
        {
            //<turple>.Item1 - x, <turple>.Item2 - y
            // find out a width and a length of the rect via given coordinates
            Width = top_left.Item2 - bottom_right.Item2;
            Length = bottom_right.Item1 - top_left.Item1;
        }
    }
}
