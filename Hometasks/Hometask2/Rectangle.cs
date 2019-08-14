using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    public class Rectangle: Figure, IDrawable
    {
        public Rectangle(int x, int y) : base(x, y) { }
        public new void Draw()
        {
            Console.WriteLine($"Rectangle\nX = {X} Y = {Y}");
        }
    }
}
