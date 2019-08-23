using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask2;
namespace Hometasks
{
    partial class Program
    {
        static void Hometask2()
        {
            #region Hometask2
            try
            {
                Console.Write("Enter x --> ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter y --> ");
                int y = Convert.ToInt32(Console.ReadLine());
                Figure f = new Figure(x, y);
                Hometask2.Rectangle r = new Hometask2.Rectangle(x, y);
                Square s = new Square(x, y);
                DrawAll(f, s, r);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
        static void DrawAll(params IDrawable[] array)
        {
            foreach (IDrawable x in array)
            {
                x.Draw();
            }
        }
    }
}
