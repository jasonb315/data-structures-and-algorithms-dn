using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter.Classes
{
    public abstract class Animal
    {
        public int ID { get; set; }
        public abstract string MakeNoise();
    }
}
