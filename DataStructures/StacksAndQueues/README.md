------------------------------

# StacksAndQueues
#### *Author: Jason Burns*

------------------------------

## QUEUE

In computer science, a queue is a collection in which the entities in the collection are kept in order and the principal (or only) operations on the collection are the addition of entities to the rear terminal position, known as enqueue, and removal of entities from the front terminal position, known as dequeue. This makes the queue a First-In-First-Out (FIFO) data structure. In a FIFO data structure, the first element added to the queue will be the first one to be removed. This is equivalent to the requirement that once a new element is added, all elements that were added before have to be removed before the new element can be removed. Often a peek or front operation is also entered, returning the value of the front element without dequeuing it. A queue is an example of a linear data structure, or more abstractly a sequential collection.

## STACK

In computer science, a stack is an abstract data type that serves as a collection of elements, with two principal operations:

push, which adds an element to the collection, and

pop, which removes the most recently added element that was not yet removed.

The order in which elements come off a stack gives rise to its alternative name, LIFO (last in, first out). Additionally, a peek operation may give access to the top without modifying the stack. The name "stack" for this type of structure comes from the analogy to a set of physical items stacked on top of each other, which makes it easy to take an item off the top of the stack, while getting to an item deeper in the stack may require taking off multiple other items first.

------------------------------

## Stack Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Peek | Looks at and returns the head of the structure without mutating it | O(1) | O(1) | myStack.Peek() |
| Push | Place a new Node with data at the top of the stack | O(1) | O(1) | myStack.Push(oject) |
| Pop | Removes a Node fro mthe top of the stack and returns it's data | O(1) | O(1) | myStack.Pop() |

## Queue Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Peek | Looks at and returns the head of the structure without mutating it | O(1) | O(1) | myQueue.Peek() |
| Enqueue | Place a new Node with data at the tail of the queue | O(1) | O(1) | myList.Enqueue(object) |
| Dequeue | Remove a Node with data from the head of the queue and return it's data | O(1) | O(1) | myList.Dequeue() |

------------------------------
<!-- ## DEMO -->
<!-- ![singly_linked_list_0](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/master/assets/singly_linked_list_0.JPG) <br> -->
------------------------------

## Change Log

1.0.0 1APR2019 Initial submit

------------------------------