------------------------------

# Queue with Stacks
#### *Author: Jason Burns*

------------------------------

## Description

Problem Domain:

Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:

enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.

dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.

The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.

Proposed Solution:

The stack should flip over between Enqueue and Dequeue so that push on one and pop on the other sumulate the FIFO nature of a Queue.

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Enqueue | Enqueues a node(data) to the enqueue stack | O(n) initial, O(1) for consecutive calls| O(1) | PseudoQueue.Enqueue() |
| Dequeue | Dequeues a node(data) from the dequeue stack |O(n) initial, O(1) for consecutive calls| O(1) | O(1) | PseudoQueue.Dequeue() |

------------------------------

<!-- ## Visuals
![Merge Lists](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/ll_merge/Challenges/LLMerge/LLMerge/assets/Capture.JPG) -->

------------------------------

## Change Log
1.0.0 2APR2019 *Initial publish*

------------------------------