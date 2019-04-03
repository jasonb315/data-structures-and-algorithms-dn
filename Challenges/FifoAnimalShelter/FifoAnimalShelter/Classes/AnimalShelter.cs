using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace FifoAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Queue dogs = new Queue();
        public Queue cats = new Queue();
        public int tagID = 0;
        // no vars passed on instantiation

        public void Enqueue(Animal ani)
        {
            if (ani.MakeNoise() == "Meow")
            {
                ani.ID = tagID;
                cats.Enqueue(ani);

            }
            else if (ani.MakeNoise() == "Woof")
            {
                ani.ID = tagID;
                dogs.Enqueue(ani);
            }
            tagID++;

        }

        public Animal Dequeue(string species)
        {
            if ( species.ToLower() == "dog" )
            {
                if (dogs.head != null)
                {
                    return (Dog)dogs.Dequeue();
                }
                else
                {
                    return null;
                }
            }
            else if ( species.ToLower() == "cat")
            {
                if (cats.head != null)
                {
                    return (Cat)cats.Dequeue();
                }
                else
                {
                    return null;
                }
            }
            // return animal waiting longest
            else if (dogs.head != null && cats.head != null)
            {
                Animal checkDog = (Dog)dogs.Peek();
                int dogTag = checkDog.ID;

                Animal checkCat = (Cat)cats.Peek();
                int catTag = checkCat.ID;

                if (dogTag > catTag)
                {
                    return (Dog)dogs.Dequeue();
                }
                else if (dogTag < catTag)
                {
                    return (Cat)cats.Dequeue();
                }
            }
            else
            {
                Console.WriteLine("Please select a \"cat\" or \"dog\"");
            }

            return null;

        }
    }

}
