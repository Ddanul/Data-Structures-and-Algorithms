using FIFOAnimalShelter.Classes;
using System;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FIFOAnimalShelter();
        }

        static void FIFOAnimalShelter()
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();

            AnimalShelter animalShelter = new AnimalShelter(cat1);
            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(dog2);
            animalShelter.Enqueue(cat2);

            Console.WriteLine(animalShelter.Print());

            Console.WriteLine($"The animal taken out is {animalShelter.Dequeue("Dog").Name}");

            Console.WriteLine(animalShelter.Print());
        }
    }
}
