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
            if (top_left.Item2 < bottom_right.Item2 ||
               bottom_right.Item1 < top_left.Item1)
            {
                Console.WriteLine("Invalid coordinates!");
                Width = 0;
                Length = 0;
            }
            else
            {
                Width = Math.Abs(top_left.Item2) - Math.Abs(bottom_right.Item2);
                Length = Math.Abs(bottom_right.Item1) - Math.Abs(top_left.Item1);
            }
        }
    }
}
