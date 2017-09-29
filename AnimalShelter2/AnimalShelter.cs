using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    internal class AnimalShelter
    {
        int usedPlaces;
        int registeredDogs;
        internal Dog[] dogs;

        internal AnimalShelter(int size)
        {
            dogs = new Dog[size];
            usedPlaces = 0;
            registeredDogs = 0;
        }



        internal void Shelter(Dog newDog)
        {

            if (this.usedPlaces < dogs.Length)
            {
                this.dogs[this.usedPlaces] = newDog;
                Console.WriteLine("{0} was successfully sheltered.", newDog.Name);
                this.usedPlaces++;
            }
            else
            {
                Console.WriteLine("Sorry - no room for " + newDog.Name);
            }

        }

        internal Dog Release(int dogNum)
        {
            if (dogNum < 0)
            {
                Console.WriteLine("invalid value.");
            }
            if (dogNum > this.usedPlaces)
            {
                Console.WriteLine("there is no dog with this value.");
            }

            Dog releasedDog = this.dogs[dogNum];

            for (int i = dogNum; i < this.usedPlaces -1; i++)
            {
                this.dogs[i] = this.dogs[i + 1];
                this.dogs[this.usedPlaces - 1] = null;
                this.usedPlaces--;
            }
        return releasedDog;
        }
    }
}
