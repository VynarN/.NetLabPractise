using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    public class Square: Figure, IDrawable
    {
        public Square(int x, int y) : base(x, y) { }
        public new void Draw()
        {
            Console.WriteLine($"Square\nX = {X} Y = {Y}");
        }
    }
}
