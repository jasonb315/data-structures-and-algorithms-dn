------------------------------

# Linked List
#### *Author: Jason Burns*

------------------------------

## Description
In computer science, a linked list is a linear collection of data elements, whose order is not given by their physical placement in memory. Instead, each element points to the next. It is a data structure consisting of a collection of nodes which together represent a sequence. In its most basic form, each node contains: data, and a reference to the next node in the sequence. -wikipediam

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` to the head of `Linked List` | O(1) | O(1) | myList.Insert(99) |
| Append | Adds a new `Node` to the tail of `Linked List` | O(n) | O(1) | myList.Append(99) |
| Includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| ReadThrough | Prints the `Linked List` to the console | O(n) | O(1) | myList.ReadThrough() |
| InsertBefore | Insert a node(val) before a node of a given search value | O(n) | O(1) | myList.InsertBefore(3, 2) |
| InsertAfter | Insert a node(val) after a node of a given search value | O(n) | O(1) | myList.InsertAfter(3, 2) |
| KthFromEnd | Returns the value of the node which is K from the end (indexed from 0) | O(n+k) | O(1) | myList.KthFromEnd(2) |





------------------------------

## INSERT, APPEND, INCLUDES *using ReadThrough
![singly_linked_list_0](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/master/assets/singly_linked_list_0.JPG) <br>


------------------------------

## Change Log
1.0.0 25MAR2019 Initial submit

1.1.0 25MAR2019 Node given constructor method

1.1.0 27MAR2019 KthFromEnd

------------------------------