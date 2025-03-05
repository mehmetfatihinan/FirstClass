using System;
using System.ComponentModel;

namespace FirstClass
{
    class FirstClass
    {
        static void Main(string[] args)
        {

            Person student1 = new Person {

                //student1
                Name = "Ahmet",
                SurName = "Yılmaz",
                Birthday = new DateTime(1990, 1, 1)

            };

            Person student2 = new Person {
                //student2
                Name = "Mehmet",
                SurName = "Yılmaz",
                Birthday = new DateTime(1990, 1, 1)

            };

            Person teacher1 = new Person
            {
                //teacher1
                Name = "Ayşe",
                SurName = "Yılmaz",
                Birthday = new DateTime(1990, 1, 1)
            };

            teacher1.Print();
            student1.Print();
            student2.Print();

            Console.ReadKey();


        }
    }
}