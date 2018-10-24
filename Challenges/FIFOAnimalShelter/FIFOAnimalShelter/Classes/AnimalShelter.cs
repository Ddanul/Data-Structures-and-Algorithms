using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public int numberOfAnimals;

        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
            numberOfAnimals++;
        }

        /// <summary>
        /// adds cat or dog to the rear of the animal shelter queue
        /// </summary>
        /// <param name="animal"></param>
        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
            numberOfAnimals++;
        }

        /// <summary>
        /// removes first animal from the front of the animal shelter queue
        /// </summary>
        /// <returns>either a cat or a dog</returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;

            numberOfAnimals--;
            return temp;
        }

        /// <summary>
        /// returns cat or dog based on argument passed in.
        /// </summary>
        /// <param name="animal">cat or dog</param>
        /// <returns>cat or dog closest to the front</returns>
        public Animal Dequeue(string animal)
        {
            int counter = numberOfAnimals;
            Animal temp;
            Animal returnAnimal = null;
            
            while(counter > 0)
            {
                temp = this.Dequeue();
                if(temp.Name == animal && returnAnimal == null)
                {
                    returnAnimal = temp;
                }
                else
                {
                    this.Enqueue(temp);
                }
                counter--;
            }
            
            return returnAnimal;
        }

        /// <summary>
        /// Prints out cat or dog in order in queue
        /// </summary>
        /// <returns>string with order</returns>
        public string Print()
        {
            string animals = "";
            int counter = numberOfAnimals;
            Animal temp;
            while(counter > 1)
            {
                temp = this.Dequeue();
                animals += temp.Name + " --> ";
                counter--;
                this.Enqueue(temp);
            }
            temp = this.Dequeue();
            animals += temp.Name + " --> Null";
            this.Enqueue(temp);

            return animals;
        }
    }
}
