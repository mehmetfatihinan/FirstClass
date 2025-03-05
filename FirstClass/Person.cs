using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime Birthday { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Surname: {SurName}, Birthdate: {Birthday}");
        }

        

    }
}
