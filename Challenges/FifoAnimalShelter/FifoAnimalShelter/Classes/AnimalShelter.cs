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
            ani.ID = tagID;
            tagID++;
            dogs.Enqueue(ani);
        }

        public Animal Dequeue(string species)
        {
            if ( species.ToLower() == "dog" )
            {

            }
            else if ( species.ToLower() == "cat")
            {

            }
            else
            {

            }

        }
    }

}
