using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to check enqueue is working.
        /// </summary>
        [Fact]
        public void EnqueueOneCatAndDog()
        {
            //Arrange
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();

            AnimalShelter spca = new AnimalShelter(cat1);
            spca.Enqueue(dog1);

            string expected = "Cat --> Dog --> Null";

            //Assert
            Assert.Equal(expected, spca.Print());
        }

        [Fact]
        public void EnqueueTwoCatsAndOneDog()
        {
            //Arrange
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Dog dog1 = new Dog();

            AnimalShelter spca = new AnimalShelter(cat1);
            spca.Enqueue(dog1);
            spca.Enqueue(cat2);

            string expected = "Cat --> Dog --> Cat --> Null";

            //Assert
            Assert.Equal(expected, spca.Print());
        }

        [Fact]
        public void EnqueueTwoCatsAndTwoDogs()
        {
            //Arrange
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();

            AnimalShelter spca = new AnimalShelter(cat1);
            spca.Enqueue(dog1);
            spca.Enqueue(cat2);
            spca.Enqueue(dog2);

            string expected = "Cat --> Dog --> Cat --> Dog --> Null";

            //Assert
            Assert.Equal(expected, spca.Print());
        }

        /// <summary>
        /// Test to show animals are being dequeued
        /// </summary>
        [Theory]
        [InlineData("Cat", "Dog --> Cat --> Dog --> Null")]
        [InlineData("Dog", "Cat --> Cat --> Dog --> Null")]
        public void DequeueAnyOldAnimalInThePlace(string animal, string expected)
        {
            //Arrange
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();

            AnimalShelter spca = new AnimalShelter(cat1);
            spca.Enqueue(dog1);
            spca.Enqueue(cat2);
            spca.Enqueue(dog2);

            spca.Dequeue(animal);

            //Assert
            Assert.Equal(expected, spca.Print());
        }

        /// <summary>
        /// Test to show 2 animals are being dequeued
        /// </summary>
        [Fact]
        public void DequeueTwoDogsInThePlace()
        {
            //Arrange
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();

            AnimalShelter spca = new AnimalShelter(cat1);
            spca.Enqueue(dog1);
            spca.Enqueue(cat2);
            spca.Enqueue(dog2);

            spca.Dequeue("Dog");
            spca.Dequeue("Dog");

            //Assert
            Assert.Equal("Cat --> Cat --> Null", spca.Print());
        }
    }
}
