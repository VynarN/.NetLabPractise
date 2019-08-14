using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    public class Figure:IDrawable
    {
        public int X { get; }
        public int Y { get; }
        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Draw()
        {
            Console.WriteLine($"Figure\nX = {X} Y = {Y}");
        }
    }
}
