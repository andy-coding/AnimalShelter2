using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    internal class Dog
    {

        internal string Name
        { get; set; }

        internal int Age
        { get; set; }


        internal Dog()
        {

            int age;
            Console.Write("Enter name of dog: ");
            string dogName = Console.ReadLine();

            Console.Write("Enter age of dog: ");
            bool intCheck = int.TryParse(Console.ReadLine(), out age);

            this.Name = dogName;
            this.Age = age;


            Console.WriteLine("Dog registered");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
