using FifoAnimalShelter.Classes;
using System;
using System.Collections.Generic;

namespace FifoAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string appName = "FIFO ANIMAL SHELTER";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ForegroundColor = ConsoleColor.White;

            FifoAnimalShelter();
        }

        static void FifoAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter();

            List<Animal> animals = new List<Animal>();

            Cat wiskers = new Cat();
            Cat bonkers = new Cat();
            Cat catters = new Cat();
            Dog spot = new Dog();
            Dog bone = new Dog();
            Dog wags = new Dog();

            animals.Add(wiskers);
            animals.Add(spot);
            animals.Add(bonkers);
            animals.Add(catters);
            animals.Add(bone);
            animals.Add(wags);

            foreach (var animal in animals)
            {
                shelter.Enqueue(animal);
            }

            while (true)
            {
                Console.WriteLine("Weocome to Rainin' Cats and Dogs!");
                Console.WriteLine("1] Adopt");
                Console.WriteLine("2] Deopt");
                string selectAction = Console.ReadLine();


                if (selectAction == "1")
                {
                    Console.WriteLine("Adopt: Cat or Dog?");
                    Console.WriteLine("1] Cat");
                    Console.WriteLine("2] Dog");
                    string selectType = Console.ReadLine();

                    if (selectType == "1")
                    {
                        Cat adopteeCat = (Cat)shelter.Dequeue("cat");
                        Console.WriteLine("Cat with tag: " + adopteeCat.ID + " says " + adopteeCat.MakeNoise() + "[Thanks for atopting me!]");
                        Console.ReadLine();
                    }

                    if (selectType == "2")
                    {
                        Dog adopteeDog = (Dog)shelter.Dequeue("dog");
                        Console.WriteLine("Dog with tag: " + adopteeDog.ID + " says " + adopteeDog.MakeNoise() + "[Thanks for atopting me!]");
                        Console.ReadLine();
                    }
                }
                else if (selectAction == "2")
                {
                    Console.WriteLine("Deopt: cat or dog?");

                    string selectType = Console.ReadLine();

                    if (selectType == "cat")
                    {
                        Cat deCat = new Cat();
                        Console.WriteLine(deCat.MakeNoise() + " [bye!]");
                        shelter.Enqueue(deCat);
                    }
                    else if (selectType == "dog")
                    {
                        Dog deDog = new Dog();
                        Console.WriteLine(deDog.MakeNoise() + " [bye!]");
                        shelter.Enqueue(deDog);
                    }
                    else
                    {
                        Console.WriteLine("Um.. cat or dog?");
                    }
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Please select 1 or 2");
                }

            }

        }

    }
}
