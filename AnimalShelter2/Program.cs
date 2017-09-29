using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Program
    {

        static void Main()
        {

            PrintMenu();
        }

        static int InputInt (int min, int max)
        {
            int inInt = -1;
            bool isValidInt;


            while (inInt < min || inInt > max)
            {

                   string inChar = Console.ReadLine();
                   isValidInt = int.TryParse(inChar, out inInt);

            if (!isValidInt)
                    {
                        Console.WriteLine("Invalid input - try again.");
                    }

            if (isValidInt && (inInt < min || inInt > max))
                    {
                        Console.WriteLine("Must be between {0} and {1}. Try again.", min, max);
                    }
              

                 
            }
            return inInt;
        }

        static void PrintMenu()
        {
            int menuSelect = 0;

            while (menuSelect != 5)
            {
                Console.WriteLine("Main Menu\n");
                Console.WriteLine("1 - Create Dog Shelter");
                Console.WriteLine("2 - Register Dog");
                Console.WriteLine("3 - Shelter Dog");
                Console.WriteLine("4 - Release Dog");
                Console.WriteLine("5 - exit program\n");


                 menuSelect = InputInt(1, 5);

                switch (menuSelect)
                {
                    case 1:
                        {
                            CreateShelter();
                            Console.Clear();
                            break;
                        }

                    case 2:
                        {

                            Dog dogs = new Dog();
                            Console.Clear();
                            break;
                        }

                    case 3:
                        {
                            // ShelterDog();
                            Console.Clear();
                            break;
                        }

                    case 4:
                        {
                            //ReleaseDog();
                            Console.Clear();
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Exiting...[press any key]");
                            Console.ReadKey();
                            return;
                        }

                    default:
                        {
                            Console.WriteLine("Try again");
                            break;
                        }

                }


            }
            
        }

        static void CreateShelter()
        {
            int shelterSize;
            Console.Write("Enter shelter size: ");
            shelterSize = InputInt(1, 20);
            AnimalShelter dogShelter = new AnimalShelter(shelterSize);

            Console.WriteLine("Shelter created. Press any key to continue.");
            Console.ReadKey();
        }



        static void ShelterDog()
        {
            /*dogShelter.Shelter(dog1);
             dogShelter.Shelter(dog2);
             dogShelter.Shelter(dog3);
         */
        }

        static void ReleaseDog()
        {
            //dogShelter.Release(2);
           // Console.WriteLine("{0} has been released.", dog2.Name);
        }

    }


}
