------------------------------

# FifoAnimalShelter
#### *Author: Jason Burns*

------------------------------

## Description

Problem Domain:

Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.

Implement the following methods:

enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.

dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Dequeue(string) | Returns a Cat or Dog instance. | O(1) | O(1) | shelter.Dequeue(string "cat"/"dog") |
| Enqueue(Animal ani) | Dedopts a Cat or Dog to AnimalShelter instance. | O(1) | O(1) | shelter.Enqueue(animal instance) |


------------------------------

## Visuals
![Animal Shelter](https://github.com/jasonb315/data_structures_and_algorithms-py/blob/master/assets/fifo_animal_shelter.jpg)


------------------------------

## Change Log
1.0.0 3APR2019 *initial submission*

------------------------------