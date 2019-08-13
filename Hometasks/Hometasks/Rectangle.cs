using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask1
{
    class Rectangle
    {
        public double Width { get; }
        public double Length { get; }
        public Rectangle((double, double)top_left, (double, double) bottom_right)
        {
            //<turple>.Item1 - x, <turple>.Item2 - y
            // find out a width and a length of the rect via given coordinates
            Width = top_left.Item2 - bottom_right.Item2;
            Length = bottom_right.Item1 - top_left.Item1;
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
