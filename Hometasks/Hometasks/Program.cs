using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask1;
using Hometask2;
namespace Hometasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu();
            while (true)
            {
                
                char option = Console.ReadKey().KeyChar;
                if (option == '0')
                {
                    break;
                }
                Console.WriteLine();
                
                switch (option)
                {
                    case '1':
                        Hometask1();
                        Menu();
                        break;
                    case '2':
                        Hometask2();
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Try again");
                        break;
                }
                   
            }
            Console.ReadKey();
        }
        static void DrawAll(params IDrawable[] array)
        {
            foreach (IDrawable x in array)
            {
                x.Draw();
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose the hometask you want to check:");
            Console.WriteLine("Hometask #1: press 1");
            Console.WriteLine("Hometask #2: press 2");
            Console.WriteLine("Exit:        press 0");
        }
        
        static void Hometask1()
        {
            #region Testing all the classes related to Rectangle
            var top_left = (x: 0.0, y: 4.0);
            var bottom_right = (x: 7.0, y: 0.0);
            Console.WriteLine("Enter coordinates:");
            try
            {
                Console.Write("X for the top left corner --> ");
                top_left.x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y for the top left corner --> ");
                top_left.y = Convert.ToDouble(Console.ReadLine());
                Console.Write("X for the bottom right corner --> ");
                bottom_right.x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y for the bottom rigth corner --> ");
                bottom_right.y = Convert.ToDouble(Console.ReadLine());
                Hometask1.Rectangle rec1 = new Hometask1.Rectangle(top_left, bottom_right);
                Console.WriteLine($"Testing Rectangle class:\nCoordinates:\n" +
                                  $"top left corner = {top_left}\n" +
                                  $"bottom rigth corner = {bottom_right}");

                Console.WriteLine($"Area: {rec1.GetArea()}");
                Console.WriteLine($"Perimeter: {rec1.GetPerimeter()}");
                Rectangle_2 rec2 = new Rectangle_2(top_left, bottom_right);
                Console.WriteLine($"Testing Rectangle class wich have automated properties instead of methods:");
                Console.WriteLine($"Area: {rec2.GetArea}");
                Console.WriteLine($"Perimeter: {rec2.GetPerimeter}");

                Console.WriteLine("Testing static Rectangle class:");
                Console.WriteLine($"Area: {StaticRectangle.GetArea(top_left, bottom_right)}");
                Console.WriteLine($"Perimeter: {StaticRectangle.GetPerimeter(top_left, bottom_right)}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
            #region Testing all the classes related to Circle
            Console.WriteLine("Testing Circle class:");
            Console.Write("Input the radius --> ");
            try
            {
                double radius = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(radius);
                Console.WriteLine($"Area: {circle.GetArea()}");
                Console.WriteLine($"Length: {circle.GetLength()}");

                Console.WriteLine("Testing static Circle class:");
                Console.WriteLine($"Area: {StaticCircle.GetArea(radius)}");
                Console.WriteLine($"Length: {StaticCircle.GetLength(radius)}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
            #region Testing ComplexNumber class
            try
            {
                Console.WriteLine("Testing ComplexNumber class:");
                Console.Write("Enter the real part --> ");
                double real = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary part --> ");
                double imaginary = Convert.ToDouble(Console.ReadLine());
                ComplexNumber ob1 = new ComplexNumber(real, imaginary);
                Console.WriteLine($"The first complex number: {ob1}");
                Console.Write("Enter the real part --> ");
                real = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the imaginary part --> ");
                imaginary = Convert.ToDouble(Console.ReadLine());
                ComplexNumber ob2 = new ComplexNumber(real, imaginary);
                Console.WriteLine($"The second complex number: {ob2}");
                Console.WriteLine($"({ob1}) + ({ob2}) = {ob1 + ob2}");
                Console.WriteLine($"({ob1}) - ({ob2}) = {ob1 - ob2}");
                Console.WriteLine($"({ob1}) * ({ob2}) = {ob1 * ob2}");
                Console.WriteLine($"({ob1}) / ({ob2}) = {ob1 / ob2}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
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
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }
}
