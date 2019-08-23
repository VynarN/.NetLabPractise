using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask3;
namespace Hometasks
{
    partial class Program
    {
        static void Hometask3()
        {
            #region Task1
            List<Person> list = new List<Person>(10);
            list.Add(new Person()
            {
                Name = "Nazar",
                Age = 20,
                PhoneNumbers = new List<string>(3) { "0932345212", "0974295235", "0972341232" }
            });
            list.Add(new Person()
            {
                Name = "Ivan",
                Age = 22,
                PhoneNumbers = new List<string>(3) { "0632043912", "0967341235", "0974124324" }
            });
            list.Add(new Person()
            {
                Name = "Taras",
                Age = 18,
                PhoneNumbers = new List<string>(3) { "0939349532", "0977723411", "0923234512" }
            });
            list.Add(new Person()
            {
                Name = "Igor",
                Age = 19,
                PhoneNumbers = new List<string>(3) { "0633481234", "0962121238", "0682349111" }
            });
            list.Add(new Person()
            {
                Name = "Yurii",
                Age = 24,
                PhoneNumbers = new List<string>(3) { "0932345212", "0974295235", "0960004212" }
            });
            list.Add(new Person()
            {
                Name = "Andrii",
                Age = 20,
                PhoneNumbers = new List<string>(3) { "0944452419", "0972299415", "0960773816" }
            });

            foreach (Person pers in list)
            {
                Console.WriteLine($"Name: {pers.Name, 12}\t Age: {pers.Age, 5}");
            }
            #endregion
            #region Task2
            list.AddRange(new List<Person>() { 
            new Person()
            {
                Name = "Sergii",
                Age = 25,
                PhoneNumbers = new List<string>(3) { "0988432211", "0999323111", "0960023334" }
            },
            new Person()
            {
                Name = "Vladyslav",
                Age = 19,
                PhoneNumbers = new List<string>(3) { "0921200038", "0992377737", "0969120322" }
            }});
            Console.WriteLine("Added two persons...");
            foreach(Person pers in list)
            {
                Console.Write($"Name: {pers.Name, 12}\tPhone Numbers: ");
                foreach(string x in pers.PhoneNumbers)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            #endregion
            #region Task3
            
            Console.WriteLine("Generating random strings...");
            List<string> strings = GenerateRandomStrings();
            Console.WriteLine("Strings were gererated!");
            Console.WriteLine($"Numbers of elements in the list: {strings.Count}");
            
            for(int i = 0; i < strings.Count; i++) {
                if (strings[i].StartsWith("Z"))
                {
                    strings.RemoveAt(i);
                }
                else
                {
                    for (int j = i + 1; j < strings.Count; j++)
                    {
                        if (strings[i].Equals(strings[j]))
                        {
                            strings.RemoveAt(j);
                        }
                    }
                }
            }
            strings.Sort();
            Console.WriteLine($"Numbers of elements after some manipulations: {strings.Count}");
            DisplayPage(strings);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            #endregion
        }
        static void DisplayPage(List<string> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Given collection is empty or uninitialized!");
                return;
            }
            const int ENTITIES = 5;
            Console.WriteLine("Enter the number of the page you want to check out:");
            Console.WriteLine("(Pages start from 0)");
            int page;
            if (!Int32.TryParse(Console.ReadLine(), out page) || page * ENTITIES > list.Count)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                int j = page * ENTITIES;
                int count = 0;
                while (count < ENTITIES && j < list.Count)
                {
                    Console.WriteLine(list[j]);
                    count++;
                    j++;
                }
            }
        }
        static List<string> GenerateRandomStrings()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const int CAP = 101;
            const int LENGTH = 4;
            int ALPH_LENGTH = alphabet.Length;
            List<string> list = new List<string>(CAP);
            StringBuilder temp = new StringBuilder("");
            Random rand = new Random();
            for (int i = 0; i < CAP; i++)
            {
                for (int j = 0; j < LENGTH; j++)
                {
                    temp.Append(alphabet[rand.Next(ALPH_LENGTH)]);
                }
                list.Add(temp.ToString());
                temp.Clear();
            }
            return list;
        }
    }
}
