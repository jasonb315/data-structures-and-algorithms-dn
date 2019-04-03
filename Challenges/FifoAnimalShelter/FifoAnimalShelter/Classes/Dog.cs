using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter.Classes
{
    public class Dog : Animal
    {
        public override string MakeNoise()
        {
            return "Woof";
        }
    }
}
