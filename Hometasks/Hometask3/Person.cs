using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
        //public Person(string name, int age, IEnumerable<string> phone)
        //{
        //    Name = name;
        //    Age = age;
        //    PhoneNumbers = phone;
        //}
    }
}
