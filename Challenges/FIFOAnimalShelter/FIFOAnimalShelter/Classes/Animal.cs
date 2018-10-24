using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal Next { get; set; }
    }
}
