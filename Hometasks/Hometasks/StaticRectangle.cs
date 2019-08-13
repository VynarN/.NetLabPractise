﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask1
{
    static class StaticRectangle
    {
        public static double GetArea((double, double)top_left, (double, double) bottom_right){
            double width = top_left.Item2 - bottom_right.Item2;
            double length = bottom_right.Item1 - top_left.Item1;
            return width * length;
        }
        public static double GetPerimeter((double, double) top_left, (double, double) bottom_right)
        {
            double width = top_left.Item2 - bottom_right.Item2;
            double length = bottom_right.Item1 - top_left.Item1;
            return (width + length) * 2;
        }
    }
}
