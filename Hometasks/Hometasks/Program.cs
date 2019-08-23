using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask1;
using Hometask2;
namespace Hometasks
{
    partial class Program
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
                    case '3':
                        Hometask3();
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Try again");
                        break;
                }
                   
            }
            Console.ReadKey();
        }
        
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose the hometask you want to check:");
            Console.WriteLine("Hometask #1: press 1");
            Console.WriteLine("Hometask #2: press 2");
            Console.WriteLine("Hometask #3: press 3");
            Console.WriteLine("Exit:        press 0");
        }
    }
}
