using FifoAnimalShelter.Classes;
using System;
using System.Collections.Generic;
using Xunit;
using StacksAndQueues.Classes;


namespace XUnitTestFifoAnimalShelter
{
    public class UnitTest1
    {
        [Fact]
        public void AdoptCat()
        {
            AnimalShelter shelter = new AnimalShelter();

            List<Animal> animals = new List<Animal>();

            Cat wiskers = new Cat();
            Dog spot = new Dog();
            

            animals.Add(wiskers);
            animals.Add(spot);

            foreach (var animal in animals)
            {
                shelter.Enqueue(animal);
            }

            Assert.IsType<Cat>(shelter.Dequeue("cat"));
        }

        [Fact]
        public void AdoptDog()
        {
            AnimalShelter shelter = new AnimalShelter();

            List<Animal> animals = new List<Animal>();

            Cat wiskers = new Cat();
            Dog spot = new Dog();


            animals.Add(wiskers);
            animals.Add(spot);

            foreach (var animal in animals)
            {
                shelter.Enqueue(animal);
            }

            Assert.IsType<Dog>(shelter.Dequeue("dog"));
        }

        [Fact]
        public void DeoptCat()
        {
            AnimalShelter shelter = new AnimalShelter();
            Cat wiskers = new Cat();

            shelter.Enqueue(wiskers);
            Assert.IsType<Cat>(shelter.cats.head.data);

        }

        [Fact]
        public void DeoptDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            Dog spot = new Dog();

            shelter.Enqueue(spot);
            Assert.IsType<Dog>(shelter.dogs.head.data);
        }

        [Fact]
        public void DeoptDogNull()
        {
            AnimalShelter shelter = new AnimalShelter();
            var x = shelter.Dequeue("dog");
            Assert.Null(x);
        }

        [Fact]
        public void DeoptCatNull()
        {
            AnimalShelter shelter = new AnimalShelter();
            var x = shelter.Dequeue("cat");
            Assert.Null(x);
        }
    }
}

//“Happy Path” - Expected outcome
//Expected failure
//Edge Case(if applicable/obvious)
