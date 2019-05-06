# Data Structures and Algorithms in DotNet
```
school = 'Code Fellows'
cohort = 'seattle-dn-401d7'
person = 'Jason Burns'
```
------------------------------
<a id="contents"></a>

### Contents <br>

<!-- ##### Data Structures <br>

1. [single_linked_list](#single_linked_list)

##### Sorts <br>

1. [selection_sort](#selection_sort) -->

#### Algorithms/Challenges

1. [binary_search](#binary_search)

1. [FifoAnimalShelter](#FifoAnimalShelter)

1. [FizzBuzzTree](#FizzBuzzTree)

1. [LinkedListMerge](#LLMerge)

1. [MultiBracketValidation](#MultiBracketValidation)

1. [QueueWithStacks](#QueueWithStacks)

#### Data Structures

1. [singly_linked_list](#singly_linked_list)

1. [BinaryTree](#BinaryTree)

1. [stack_queue](#stack_queue)

1. [graph](#graph)


------------------------------

<a id="binary_search"></a>

## Binary Search

### Description
Binary search on an array/list of sorted values, also known as half-interval search.
It repeatedly narrows an array by half to the left or right based on weather or not he middle point is higher, lower than the search key, until the key is found or not.

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/Challenges/BinarySearch)

<a id="FifoAnimalShelter"></a>

## Fifo Animal Shelter

### Description
Animal Shelter class that takes in cat and dog objects. A visitor(CLI) can adopt/dedopt a cat or dog.

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/Challenges/FifoAnimalShelter)

<a id="FizzBuzzTree"></a>

## Fizz Buzz Tree

### Description
Method which takes in a tree of int values, and replaces values with fizz, buzz, or fizzbuzz.

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/Challenges/FizzBuzzTree)

<a id="LLMerge"></a>

## Linked List Merge

### Description
Given two linked lists, zip them together.

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/Challenges/LLMerge)

<a id="MultiBracketValidation"></a>

## Multi Bracket Validation

### Description
Take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced.

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/Challenges/MultiBracketValidation)

<a id="QueueWithStacks"></a>

## Queue With Stacks

### Description
PseudoQueue class: a Queue made with two stacks.

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/Challenges/QueueWithStacks)



-----------------------------------------------------------
<a id="singly_linked_list"></a>

## Singly Linked List

### Description
In computer science, a linked list is a linear collection of data elements, whose order is not given by their physical placement in memory.

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/DataStructures/LinkedList)

<a id="BinaryTree"></a>

## Binary Tree

### Description
tree data structure in which each node has at most two children

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/DataStructures/BinaryTree)

<a id="stack_queue"></a>

## Stack & Queue

### Description
Stacks are like lunchtrays (FILO), and queues are like waiting lines(FIFO).

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/DataStructures/StacksAndQueues)

<a id="stack_queue"></a>

## Graph

### Description
A Graph is a set of Vertices connected by Edges, which can be directed or undirected.

[See code](https://github.com/jasonb315/data-structures-and-algorithms-dn/tree/master/DataStructures/MyGraph)

<!--
![name](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/master/assets/[name].jpg)
-->

------------------------------

## Change Log

1.0 20MAR2019 readme setup

1.1 21MAR2019 binary search added

1.2 25MAR2019 singly linked list added

1.3 29MAR2019 linked list merge

1.4 1APR2019 stack and queue

2.0 13APR2019 *readme overhaul*

2.1 4MAY2019 graph added

------------------------------

## Thankyou

Wikipedia

Stack Overflow

Dan, and Ian.

<!-- 
## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` to the `Linked List` | O(1) | O(1) | myList.Insert(99) |
| Includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| Print | Prints the `Linked List` to the console | O(n) | O(1) | myList.Print() | -->